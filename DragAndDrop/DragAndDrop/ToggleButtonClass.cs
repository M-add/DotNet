using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DragAndDrop
{
    public class TogglebButtonClass : Button
    {
        private bool condition = true;
        private int prevX;
        private int borderRadius = 40;
        private Timer transitionTimer;

        public TogglebButtonClass()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = Color.LightGray;
            ForeColor = Color.White;

            prevX = Width - Height - 3;

            InitializeTimer();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            // base.OnMouseEnter(e);
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            // base.OnMouseClick(e);
        }
        private void InitializeTimer()
        {
            transitionTimer = new Timer();
            transitionTimer.Interval = (Width / 48);
            transitionTimer.Tick += TransitionTimer;
        }

        private void TransitionTimer(object sender, EventArgs e)
        {
            int step = (Width - Height - 3) / 20;

            double l = Width / 57;
            double left = Math.Ceiling(l);

            if (condition && prevX < Width - Height - 3)
            {
                prevX += step;
            }
            else if (!condition && prevX > Width/30 )
            {
                prevX -= step;
            }
            else
            {
                transitionTimer.Stop();
            }

            Invalidate();
        }

        public bool Condition1
        {
            get { return condition; }
            set { condition = value; }
        }

        public int BorderRadius1
        {
            get { return borderRadius; }
            set { borderRadius = value; Invalidate(); }
        }

        private GraphicsPath GetGraphicsPath(Rectangle rect, int r)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, Height - 1, Height - 1, 90, 180);
            path.AddArc(Width - Height - 3, 0, Height - 1, Height - 1, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            GraphicsPath path = GetGraphicsPath(ClientRectangle, borderRadius);

            Color borderColor = Color.Black;
            Color buttonColor;

            if (condition)
            {
                buttonColor = Color.MediumSeaGreen;
            }
            else
            {
                buttonColor = Color.Crimson;
            }

            using (Brush brush = new SolidBrush(buttonColor))
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                pevent.Graphics.FillPath(brush, path);
            }
            //using (Pen pen = new Pen(borderColor, 2))
            //{
            //    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //    pevent.Graphics.DrawPath(pen, path);
            //}
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.FillEllipse(Brushes.WhiteSmoke, prevX, (Height / 20), Height - (Height / 10), Height - (Height / 10));

        }

        public event EventHandler<bool> ToggleClicked;

        protected override void OnClick(EventArgs e)
        {
            //base.OnClick(e);
            condition = !condition;

            ToggleClicked?.Invoke(this, condition);

            //InitializeTimer();
            transitionTimer.Start();
            Invalidate();
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            prevX = Width - Height - 3;
        }
    }
}
