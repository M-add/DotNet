using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace DragAndDrop
{
    public class Points
    {
        public int RippleOne = 0;
        public int ellipseX;
        public int ellipseY;

        public Timer AnimationTimer;
    }

    public class RippleButton : Button
    {
        List<Points> PointList = new List<Points>();

        private int alpha = 70;
        private bool Selected = false;

        public int Speed { get; set; } = 7;

        public Color RippleColor { get; set; } = Color.DeepPink;

        public Color CheckColor { get; set; } = Color.Pink;

        public bool Check
        {
            get { return Selected; }
            set
            {
                Selected = value;
                Invalidate();
            }
        }

        public RippleButton()
        {
            FlatStyle = FlatStyle.Flat;
            RippleColor = BackColor;
            DoubleBuffered = true;
        }

        public int Alpha
        {
            get
            {
                return alpha;
            }
            set
            {
                if (value > 150)
                {
                    value = 140;
                }
                alpha = value;
            }
        }

        protected override void OnPaint(PaintEventArgs args)
        {
            base.OnPaint(args);

            args.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            args.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            for (int i = 0; i < PointList.Count; i++)
            {
                if (PointList[i].RippleOne > 0)
                {
                    using (Brush brush = new SolidBrush(Color.FromArgb(alpha, RippleColor)))
                    {                 
                       args.Graphics.FillEllipse(brush, PointList[i].ellipseX - PointList[i].RippleOne, PointList[i].ellipseY - PointList[i].RippleOne, 2 * PointList[i].RippleOne, 2 * PointList[i].RippleOne);
                    }
                }
            }

            if(Selected)
            {
                GraphicsPath path = new GraphicsPath();

                path.StartFigure();
                path.AddLine(new Point(0, 0), new Point(Width, 0));
                path.AddLine(new Point(Width, 0), new Point(Width, Height));
                path.AddLine(new Point(Width, Height), new Point(0, Height));
                path.AddLine(new Point(0, Height), new Point(0, 0));
                path.CloseFigure();

                using (Pen pen = new Pen(CheckColor, 5)) 
                {
                    args.Graphics.DrawPath(pen, path);
                }
            }

        }

        public void DrawRipple(object sender, EventArgs args)
        {
            var completedAnimations = new List<Points>();

            foreach (var points in PointList)
            {
                if (points.AnimationTimer == sender)
                {
                    if (points.RippleOne < Width + Height / 3) 
                    {
                        points.RippleOne += Speed;

                        if (Alpha <= 60)
                        {
                            Alpha = 50;
                        }
                        else
                        {
                            Alpha -= 1;
                        }
                    }
                    else
                    {
                        points.AnimationTimer.Stop();
                        points .AnimationTimer.Dispose();
                        completedAnimations.Add(points);
                        PointList.Remove(points);
                        break;
                    }
                }
            }
            //foreach (var completedAnimation in completedAnimations)
            //{
            //    PointList.Remove(completedAnimation);
            //}
            Invalidate();

        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            //base.OnMouseClick(e);

            var points = new Points
            {
                ellipseX = e.X,
                ellipseY = e.Y,
                AnimationTimer = new Timer { Interval = 2 }
            };

            points.AnimationTimer.Tick += DrawRipple;
            points.AnimationTimer.Start();

            PointList.Add(points);

            Selected = !Selected;

            Invalidate();
        }
    }
}
