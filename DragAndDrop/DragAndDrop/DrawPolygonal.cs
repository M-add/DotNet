using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DragAndDrop
{
    public partial class DrawPolygonal : UserControl
    {
        List<Point> Points = new List<Point>();
        bool clicked = false;

        public DrawPolygonal()
        {
            InitializeComponent();
        }

        private void DrawPolygonalMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Points.Add(new Point(e.X, e.Y));
                clicked = true;
                Invalidate();
            }
            else if (e.Button == MouseButtons.Right)
            {
                clicked = false;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            if (clicked)
            {
                for (int i = 0; i < Points.Count; i++)
                {
                    e.Graphics.FillEllipse(Brushes.Red, Points[i].X, Points[i].Y, 5, 5);
                }
            }

            if (Points.Count >= 3 && !clicked)
            {
                e.Graphics.DrawPolygon(new Pen(Brushes.SteelBlue, 3), Points.ToArray());
                Points.Clear();
            }
        }
    }
}
