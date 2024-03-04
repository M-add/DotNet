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
    public partial class CircularProgressBar : UserControl
    {
        Timer animationTimer = new Timer();

        private int animationInterval = 1;
        private Color barColor = Color.Blue;
        private Color internalColor = Color.White;
        private Color barBackColor = Color.Black;
        private int barWidth = 20;

        private int actualValue;
        private int value;

        public int AnimationInterval
        {
            get { return animationInterval; }
            set { animationInterval = value; }
        }
        public int AnimationSpeed
        {
            get { return animationTimer.Interval; }
            set { animationTimer.Interval = value; }
        }
        public Color BarColor
        {
            get { return barColor; }
            set
            {
                barColor = value;
                Invalidate();
            }
        }
        public Color InternalColor
        {
            get { return internalColor; }
            set
            {
                internalColor = value;
                Invalidate();
            }
        }
        public Color BarBackColor
        {
            get { return barBackColor; }
            set
            {
                barBackColor = value;
                Invalidate();
            }
        }
        public int Value
        {
            get { return value; }
            set
            {
                if (value > 100) value = 100;
                else if (value < 0) value = 0;
                else
                {
                    this.value = value;
                }
                Invalidate();
                animationTimer.Start();
            }
        }
        public int BarWidth
        {
            get { return barWidth; }
            set
            {
                barWidth = value;
                Invalidate();
            }
        }

        public CircularProgressBar()
        {
            InitializeComponent();
            animationTimer.Interval = 50;

            animationTimer.Interval += AnimationSpeed;
            animationTimer.Tick += TickEvent;
        }

        private void TickEvent(object sender, EventArgs e)
        {
            if (actualValue < Value)
            {
                actualValue = actualValue + animationInterval;
                if (actualValue >= Value)
                {
                    actualValue = Value;
                    animationTimer.Stop();
                }
            }
            else
            {
                actualValue = actualValue - animationInterval;
                if (actualValue <= Value)
                {
                    actualValue = Value;
                    animationTimer.Stop();
                }
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            DoubleBuffered = true;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            e.Graphics.FillEllipse(new SolidBrush(barBackColor),
                Margin.Left,
                Margin.Top,
                Width - Margin.Left - Margin.Right,
                Height - Margin.Top - Margin.Bottom);

            e.Graphics.FillEllipse(new SolidBrush(internalColor),
                Margin.Left + barWidth,
                Margin.Top + barWidth,
                Width - Margin.Left - Margin.Right - barWidth * 2,
                Height - Margin.Top - Margin.Bottom - barWidth * 2);

            Pen pen = new Pen(BarColor, barWidth);
            pen.StartCap = pen.EndCap = LineCap.Round;

            e.Graphics.DrawArc(pen,
                Margin.Left + barWidth / 2,
                Margin.Top + barWidth / 2,
                Width - Margin.Left - Margin.Right - barWidth,
                Height - Margin.Top - Margin.Bottom - barWidth,
                270,
                (int)Math.Round(360.0 / 100 * actualValue)
                );

            StringFormat s = new StringFormat();
            s.Alignment = StringAlignment.Center;
            s.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(actualValue + "%", Font, new SolidBrush(ForeColor), new RectangleF(0, 0, Width, Height), s);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Height = Width;
        }
    }
}
