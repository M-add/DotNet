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
    public partial class Clock : UserControl
    {
        private Font font;
        private Color clockFrontColor = Color.Black;
        private Color clockOut = Color.Black;
        private Color clockIn = Color.WhiteSmoke;
        private Color hourHandColor = Color.Black;
        private Color minutHandColor = Color.Black;
        private Color secHandColor = Color.Black;

        private DateTime CurrentTime;

        public String Time()
        {
            return DateTime.Now.ToLongTimeString();
        }
        public Color ClockFontColor
        {
            get { return clockFrontColor; }
            set
            {
                clockFrontColor = value;
                Invalidate();
            }
        }
        public Color ClockOut
        {
            get { return clockOut; }
            set
            {
                clockOut = value;
                Invalidate();
            }
        }
        public Color ClockIn
        {
            get { return clockIn; }
            set
            {
                clockIn = value;
                Invalidate();
            }
        }
        public Color HourHandColor
        {
            get { return hourHandColor; }
            set
            {
                hourHandColor = value;
                Invalidate();
            }
        }
        public Color MinuteHandColor
        {
            get { return minutHandColor; }
            set
            {
                minutHandColor = value;
                Invalidate();
            }
        }
        public Color SecHandcolor
        {
            get { return secHandColor; }
            set
            {
                secHandColor = value;
                Invalidate();
            }
        }

        public Font Fonts
        {
            get { return font; }
            set
            {
                font = value;
                Invalidate();
            }
        }
        public Clock()
        {
            InitializeComponent();

            int fontSize = (Width * 2) / 100 + (Height * 2) / 100;
            font = new Font("Franklin Gothic", fontSize, FontStyle.Bold);

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += TimerTick;
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            DoubleBuffered = true;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            DrawClockFace(e.Graphics);


            CurrentTime = DateTime.Now;

            //e.Graphics.DrawEllipse(new Pen(Color.LightGray, 15), new RectangleF((Width * 45) / 100, (Height * 45) / 100,
            // (Width * 8.5f) / 100, (Width * 8.5f) / 100));

            DrawClockHand(e.Graphics, CalculateHourAngle(CurrentTime), 5, (Width * 20) / 100 , hourHandColor);
            DrawClockHand(e.Graphics, CalculateMinuteAngle(CurrentTime), 5, (Width * 28) / 100 , minutHandColor);
            DrawClockHand(e.Graphics, CalculateSecondAngle(CurrentTime), 3, (Width * 22) / 100 , secHandColor);

        }

        private void DrawClockFace(Graphics g)
        {
            Pen pen = new Pen(clockOut, 3);
            Rectangle layout = new Rectangle(Margin.Left, Margin.Right, Width - Margin.Left - Margin.Right,
                Height - Margin.Top - Margin.Bottom);

            g.FillEllipse(new SolidBrush(clockIn), layout);
            g.DrawEllipse(pen, layout);

            // Draw clock markings
            for (int i = 1; i <= 12; i++)
            {
                double angle = 2 * Math.PI * (i - 3) / 12;
                float x = (float)(Width * 0.5 + Math.Cos(angle) * Width * 0.4);
                float y = (float)(Height * 0.5 + Math.Sin(angle) * Height * 0.4);

                g.DrawString(i.ToString(), font, new SolidBrush(clockFrontColor), new PointF(x, y), 
                    new StringFormat() { Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center });
            }
        }

        private void DrawClockHand(Graphics g, double angle, int thickness, float length , Color color)
        {
            Point startPoint = new Point((Width * 50) / 100, (Height * 50) / 100);
            Point endPoint = new Point(
                (int)(Width * 0.5 + Math.Cos(angle) * length),
                (int)(Height * 0.5 + Math.Sin(angle) * length));

            g.DrawLine(new Pen(color, thickness), startPoint, endPoint);
        }

        private double CalculateHourAngle(DateTime time)
        {
            double hourAngle = 2 * Math.PI * ((time.Hour % 12) - 3) / 12;
            hourAngle += (2 * Math.PI / 12) * (time.Minute / 60.0);
            return hourAngle;
        }

        private double CalculateMinuteAngle(DateTime time)
        {
            double minuteAngle = 2 * Math.PI * (time.Minute - 15) / 60;
            return minuteAngle;
        }

        private double CalculateSecondAngle(DateTime time)
        {
            double secondAngle = 2 * Math.PI * (time.Second - 15) / 60;
            return secondAngle;
        }

        private void ClockLoad(object sender, EventArgs e)
        {
        }
    }
}
