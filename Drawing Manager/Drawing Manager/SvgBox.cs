using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Svg;
using System.Xml;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace Drawing_MAnager
{
    public partial class Svg_Box : UserControl
    {
        private PointF controlPoint2;
        private List<Color> ColorList = new List<Color>();

        public Svg_Box()
        {
            InitializeComponent();
        }

        private string[] SplitSvgPath(string svgPath)
        {
            string pattern = @"([MLHVCSQTAZmlhvcsqtaz])";
            string[] segments = Regex.Split(svgPath, pattern, RegexOptions.Compiled);

            //string[] segments = Regex.Split(svgPath, @"(?<=[A-Z])|(?=\d)(?<=\D)|(?=\D)(?<=\d)");

            List<string> splitted = new List<string>();
            foreach (string s in segments)
            {
                if (!string.IsNullOrEmpty(s) && char.IsUpper(s[0]) && char.IsLower(s[0]))
                {
                    splitted.Add(s);
                }
                else
                {
                    string[] split = s.Split(new[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    splitted.AddRange(split);
                    //if (split.Length >= 12)
                    //{
                    //    int Count = 0;
                    //    for (int i = 0; i < split.Length; i++)
                    //    {
                    //        splitted.Add(split[i]);
                    //        Count++;
                    //        if (Count == 6 && i < split.Length - 1)
                    //        {
                    //            splitted.Add("c");
                    //            Count = 0;
                    //        }
                    //    }
                    //}
                    //else
                    //{
                    //    splitted.AddRange(split);
                    //}
                }
            }

            return splitted.Where(segment => !string.IsNullOrWhiteSpace(segment)).ToArray();
        }
        private void DrawSvgPath(string pathData, Graphics g, Color pathColor)
        {
            string[] commands = SplitSvgPath(pathData);
            //foreach (string s in commands)
            //{
            //    richTextBox1.Text += s;
            //    richTextBox1.Text += "---";
            //}
            //richTextBox1.Text += Environment.NewLine;

            //string s = "M 0 382.5 l 256 -128 L 0 126.5 V 382.5 Z M 512 254.5 l -256 -128 v 128 v 128 L 512 254.5 Z";

            Pen pen = new Pen(pathColor);
            PointF lastPoint = PointF.Empty;
            PointF startingPoint = PointF.Empty;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.ScaleTransform(5f, 5f);
            pen.StartCap = pen.EndCap = LineCap.Round;

            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == "M")
                {

                    float x = float.Parse(commands[i + 1]);
                    float y = float.Parse(commands[i + 2]);
                    startingPoint = lastPoint;
                    lastPoint = new PointF(x, y);
                    i += 2;
                }
                else if (commands[i] == "m")
                {
                    float x = float.Parse(commands[i + 1]);
                    float y = float.Parse(commands[i + 2]);
                    lastPoint = new PointF(lastPoint.X + x, lastPoint.Y + y);
                    startingPoint = lastPoint;
                    i += 2;
                }
                else if (commands[i] == "L")
                {
                    float x = float.Parse(commands[i + 1]);
                    float y = float.Parse(commands[i + 2]);
                    g.DrawLine(pen, lastPoint, new PointF(x, y));
                    lastPoint = new PointF(x, y);
                    i += 2;
                }
                else if (commands[i] == "l")
                {
                    float x = float.Parse(commands[i + 1]);
                    float y = float.Parse(commands[i + 2]);
                    g.DrawLine(pen, lastPoint, new PointF(lastPoint.X + x, lastPoint.Y + y));
                    lastPoint = new PointF(lastPoint.X + x, lastPoint.Y + y);
                    i += 2;
                }

                else if (commands[i] == "V")
                {
                    float y = float.Parse(commands[i + 1]);
                    g.DrawLine(pen, lastPoint, new PointF(lastPoint.X, y));
                    lastPoint = new PointF(lastPoint.X, y);
                    i += 1;
                }
                else if (commands[i] == "v")
                {
                    float y = float.Parse(commands[i + 1]);
                    g.DrawLine(pen, lastPoint, new PointF(lastPoint.X, lastPoint.Y + y));
                    lastPoint = new PointF(lastPoint.X, lastPoint.Y + y);
                    i += 1;
                }
                else if (commands[i] == "C")
                {
                    float x1 = float.Parse(commands[i + 1]);
                    float y1 = float.Parse(commands[i + 2]);
                    float x2 = float.Parse(commands[i + 3]);
                    float y2 = float.Parse(commands[i + 4]);
                    float x = float.Parse(commands[i + 5]);
                    float y = float.Parse(commands[i + 6]);

                    g.DrawBezier(pen, lastPoint, new PointF(x1, y1),
                        new PointF(x2, y2), new PointF(x, y));
                    lastPoint = new PointF(x, y);
                    i += 6;
                }
                else if (commands[i] == "c")
                {
                    float x1 = float.Parse(commands[i + 1]);
                    float y1 = float.Parse(commands[i + 2]);

                    float x2 = float.Parse(commands[i + 3]);
                    float y2 = float.Parse(commands[i + 4]);

                    float x = float.Parse(commands[i + 5]);
                    float y = float.Parse(commands[i + 6]);

                    x1 += lastPoint.X;
                    y1 += lastPoint.Y;

                    x2 += lastPoint.X;
                    y2 += lastPoint.Y;

                    x += lastPoint.X;
                    y += lastPoint.Y;

                    g.DrawBezier(pen, lastPoint,
                                 new PointF(x1, y1),
                                 new PointF(x2, y2),
                                 new PointF(x, y));

                    lastPoint = new PointF(x, y);

                    i += 6;
                }
                else if (commands[i] == "s")
                {
                    if (i > 0 && (commands[i - 1] == "c" || commands[i - 1] == "s"))
                    {
                        float reflectedX2 = 2 * lastPoint.X - controlPoint2.X;
                        float reflectedY2 = 2 * lastPoint.Y - controlPoint2.Y;

                        float x1 = reflectedX2;
                        float y1 = reflectedY2;

                        float x2 = float.Parse(commands[i + 1]);
                        float y2 = float.Parse(commands[i + 2]);

                        float x = float.Parse(commands[i + 3]);
                        float y = float.Parse(commands[i + 4]);

                        x1 += lastPoint.X;
                        y1 += lastPoint.Y;

                        x2 += lastPoint.X;
                        y2 += lastPoint.Y;

                        x += lastPoint.X;
                        y += lastPoint.Y;

                        g.DrawBezier(pen, lastPoint,
                                     new PointF(x1, y1),
                                     new PointF(x2, y2),
                                     new PointF(x, y));

                        lastPoint = new PointF(x, y);
                        controlPoint2 = new PointF(x2, y2);

                        i += 4;
                    }
                    else
                    {
                        float x1 = lastPoint.X;
                        float y1 = lastPoint.Y;

                        float x2 = float.Parse(commands[i + 1]);
                        float y2 = float.Parse(commands[i + 2]);

                        float x = float.Parse(commands[i + 3]);
                        float y = float.Parse(commands[i + 4]);

                        x2 += lastPoint.X;
                        y2 += lastPoint.Y;

                        x += lastPoint.X;
                        y += lastPoint.Y;

                        g.DrawBezier(pen, lastPoint,
                                     new PointF(x1, y1),
                                     new PointF(x2, y2),
                                     new PointF(x, y));

                        lastPoint = new PointF(x, y);
                        controlPoint2 = new PointF(x2, y2);

                        i += 4;
                    }
                }

                else if (commands[i] == "H" || commands[i] == "h")
                {
                    float x = float.Parse(commands[i + 1]);
                    g.DrawLine(pen, lastPoint, new PointF(x, lastPoint.Y));
                    lastPoint = new PointF(x, lastPoint.Y);
                    i += 1;
                }
                else if (commands[i] == "h")
                {
                    float x = float.Parse(commands[i + 1]);
                    g.DrawLine(pen, lastPoint, new PointF(lastPoint.X + x, lastPoint.Y));
                    lastPoint = new PointF(lastPoint.X + x, lastPoint.Y);
                    i += 1;
                }
                else if (commands[i] == "Z" || commands[i] == "z")
                {
                    //g.DrawLine(pen, lastPoint, startingPoint);
                    lastPoint = startingPoint;
                }
            }
            g.ResetTransform();
        }


        private void ImportButton_Click_1(object sender, EventArgs e)
        {
            DrawPanel.Invalidate();
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "SVG files (*.svg)|*.svg",
                Title = "Select SVG File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string svgPath = openFileDialog.FileName;
                List<string> pathDataList = GetSvgPathData(svgPath);

                //DrawPanel.Invalidate();
                for (int i = 0; i < pathDataList.Count; i++)
                {
                    DrawSvgPath(pathDataList[i], DrawPanel.CreateGraphics(), ColorList.Count != 0 ? ColorList[i] : Color.Black);
                }
                DrawPanel.Tag = pathDataList;
            }
        }

        private List<string> GetSvgPathData(string svgPath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(svgPath);

            XmlNamespaceManager nsManager = new XmlNamespaceManager(xmlDoc.NameTable);
            nsManager.AddNamespace("svg", "http://www.w3.org/2000/svg");

            List<string> pathDataList = new List<string>();


            XmlNodeList pathNodes = xmlDoc.SelectNodes("//svg:path", nsManager);

            foreach (XmlNode pathNode in pathNodes)
            {
                XmlAttribute dAttribute = pathNode.Attributes["d"];
                if (dAttribute != null)
                {
                    pathDataList.Add(dAttribute.Value);
                }
                XmlAttribute colorAtribute = pathNode.Attributes["fill"];
                if (colorAtribute != null)
                {
                    string color = colorAtribute.Value;
                    Color pathColor = ColorTranslator.FromHtml(color);
                    ColorList.Add(pathColor);
                }
            }

            return pathDataList;
        }
    }
}
