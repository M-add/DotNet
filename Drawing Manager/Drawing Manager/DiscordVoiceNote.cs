using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Drawing_MAnager
{
    public partial class DiscordVoiceNote : UserControl
    {
        private Timer timer;

        private bool playBack = false;
        private Color EllipseColor = Color.FromArgb(92, 60, 224);
        private Color playBackColor = Color.White;
        private Color InitialColor = Color.FromArgb(102, 102, 99);

        private List<Point> points = new List<Point>();
        private float animationProgress = 1f;
        private int Count = 0;

        public DiscordVoiceNote()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += TimerTick;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.Location.X >= (Width * 10) / 100 && e.Location.X <= (Width * 30) / 100)
            {
                playBack = !playBack;
            }

            EllipseColor = playBack ? Color.White : Color.FromArgb(92, 60, 224);
            playBackColor = !playBack ? Color.White : Color.FromArgb(92, 60, 224);
            //InitialColor = !playBack ? Color.FromArgb(102, 102, 99) : Color.FromArgb(92, 60, 224);
            animationProgress = 1f;
            timer.Start();
            Invalidate();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            animationProgress += 5f;
            if (animationProgress >= Width)
            {
                timer.Stop();
            }
            else
            {
                Invalidate();
            }
            if (Count < 8)
            {
                Count++;
            }
            else
            {
                Count = 0;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            DoubleBuffered = true;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighSpeed;

            Brush initial = new SolidBrush(InitialColor);
            Pen pen = new Pen(Color.WhiteSmoke, 2);
            pen.StartCap = pen.EndCap = LineCap.Round;

            //BackGround Path
            GraphicsPath path = new GraphicsPath();

            RectangleF left = new RectangleF((Width * 3.1f) / 100, 0, (Width * 45) / 100, Height);
            Rectangle right = new Rectangle((Width * 45) / 100, 0, (Width * 45) / 100, Height);
            path.StartFigure();
            path.AddArc(left, 90, 180);
            path.AddArc(right, 270, 180);
            path.CloseFigure();
            e.Graphics.FillPath(initial, path);


            if (playBack)
            {
                Region region = new Region(path);
                RectangleF fill = new RectangleF((Width * 3.1f) / 100, 1, animationProgress, Height - 2);
                region.Intersect(fill);
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(190, 92, 60, 224)))
                {
                    e.Graphics.FillRegion(brush, region);
                }
                pen = new Pen(Color.WhiteSmoke, 5);
            }
            else
            {
                e.Graphics.FillPath(initial, path);
            }

            //Lines
            for (int i = 0; i < 5; i++)
            {
                Point p1 = new Point((Width * 45 + (i * 1000)) / 100, (Height * 30) / 100);
                Point p2 = new Point((Width * 45 + (i * 1000)) / 100, (Height * 70) / 100);

                points.Add(p1);
                points.Add(p2);

                e.Graphics.DrawLine(pen, p1, p2);
            }

            //Inner Ellipse
            Brush EllipseBrush = new SolidBrush(EllipseColor);
            e.Graphics.FillEllipse(EllipseBrush,
                new RectangleF((Width * 10) / 100, (Height * 10) / 100,
                (Width * 30) / 100, (Width * 30) / 100));

            //Play & Pause
            Brush PlayBackBrush = new SolidBrush(playBackColor);
            if (!playBack)
            {
                int playSize = (Width * 15) / 100;
                int playX = (Width * 20) / 100;
                int playY = (Height * 30) / 100;
                Point[] playPoints =
                {
                    new Point(playX, playY),
                    new Point(playX + playSize, playY + playSize / 2),
                    new Point(playX, playY + playSize),
                };

                e.Graphics.FillPolygon(PlayBackBrush, playPoints);
            }

            if (playBack)
            {
                int pauseX = (Width * 18) / 100;
                int pauseY = (Height * 28) / 100;
                int PauseWidth = (Width * 5) / 100;
                int PauseHeight = (Height * 45) / 100;
                e.Graphics.FillRectangle(PlayBackBrush, new Rectangle(pauseX, pauseY,
                    PauseWidth, PauseHeight));
                e.Graphics.FillRectangle(PlayBackBrush, new Rectangle(pauseX + PauseWidth + PauseWidth, pauseY,
                    PauseWidth, PauseHeight));
            }
        }
    }
}
