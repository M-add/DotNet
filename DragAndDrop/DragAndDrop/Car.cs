using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDrop
{
    public partial class Car : UserControl
    {
        //private int carX;
        public Car()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            GraphicsPath path = new GraphicsPath();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            DoubleBuffered = true;

            //upper part
            int x = (Width / 100) * 20;
            int y = (Height / 100) * 7;

            Rectangle upperPart = new Rectangle(x, y, (Width / 100) * 60, (Height / 100) * 90);
            path.StartFigure();
            path.AddArc(upperPart, 180, 180);
            path.CloseFigure();

            g.FillPath(Brushes.Azure, path);

            int centerX = x + (Width / 100) * 25;
            int centerY = y + Height / 2;
            using (Pen pen = new Pen(Color.Black, 3))
            {
                g.DrawPath(pen, path);
                g.DrawLine(pen, centerX, y, centerX, Height / 1.8f);
            }

            //Main Body
            GraphicsPath BodyPath = new GraphicsPath();
            int cornerRadius = (Width / 100) * 5;

            BodyPath.StartFigure();
            BodyPath.AddArc(x - 30, (Height / 100) * 45, 2 * cornerRadius, 2 * cornerRadius, 180, 90);
            BodyPath.AddArc((Width / 100) * 95, (Height / 100) * 45, 2 * cornerRadius, 2 * cornerRadius, 270, 90);
            BodyPath.AddArc((Width / 100) * 95, (Height / 100) * 85, 2 * cornerRadius, 2 * cornerRadius, 0, 90);
            BodyPath.AddArc(x - 30, (Height / 100) * 85, 2 * cornerRadius, 2 * cornerRadius, 90, 90);
            BodyPath.CloseFigure();

            g.FillPath(Brushes.MidnightBlue, BodyPath);

            GraphicsPath light = new GraphicsPath();
            Rectangle lights = new Rectangle((Width / 100) * 99, (Height / 100) * 50, 30, 30);
            light.StartFigure();
            light.AddArc(lights, 270, 180);
            light.CloseFigure();
            g.FillPath(Brushes.LightGoldenrodYellow, light);

            //Wheels
            g.FillEllipse(Brushes.Black, x, y + (Height / 100) * 85, 50, 50);
            g.FillEllipse(Brushes.Black, x + Width / 2, y + (Height / 100) * 85, 50, 50);

            //Silencer
            using (Pen pen = new Pen(Color.LightSteelBlue, 10))
            {
                g.DrawLine(pen, 0, (Height / 100) * 90, x - 30, (Height / 100) * 90);
            }              
        }
    }
}
