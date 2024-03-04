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
    public partial class Ripple : UserControl
    {
        public class Ripples
        {
            public Point Location;
            public Size Size;
            public int MaxHeight;
            public Color Color;
            public int LocationOffset;
            public int Inflate;

            public Ripples(Point location, Size size, int maxHeight, Color color, int locationOffset, int inflate)
            {
                Location = location;
                Size = size;
                MaxHeight = maxHeight;
                Color = color;
                LocationOffset = locationOffset;
                Inflate = inflate;
            }
        }

        //private Color DarkShade = Color.FromArgb(110, 110, 110);
        //private Color WhiteShade = Color.FromArgb(180, 180, 180);
        private Color BlueShade = Color.FromArgb(50, 70, 255);

        private Color RippleBackColor = Color.Black;
        private int alpha = 80;

        List<Ripples> RippleList = new List<Ripples>();
        private Timer timer;

        public Ripple()
        {
            InitializeComponent();

            //this.MouseClick += RippleMouseClick;
        }

        private void RippleMouseClick(object sender, MouseEventArgs e)
        {
            int maxHeight = Math.Max(Height, Width) * 2;

            RippleList.Add(new Ripples(e.Location, new Size((Width / 100) * 5, (Height / 100) * 5), maxHeight, RippleBackColor, 0, 0));

            timer = new Timer();
            timer.Interval = 1;
            timer.Tick += TimerTick;
            timer.Start();

            Invalidate();
        }

        private void RipplePaint(object sender, PaintEventArgs e)
        {
            DoubleBuffered = true;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            for (int i = 0; i < RippleList.Count; i++)
            {
                Ripples ripple = RippleList[i];
                using (var brush = new SolidBrush(Color.FromArgb(alpha, RippleBackColor)))
                {
                    int x = ripple.Location.X - ripple.LocationOffset - (ripple.Inflate/2);
                    int y = ripple.Location.Y - ripple.LocationOffset - (ripple.Inflate/2);
                    int width = ripple.Size.Width + ripple.Inflate;
                    int height = ripple.Size.Height + ripple.Inflate;

                    e.Graphics.FillEllipse(brush, x, y, width, height);
                }
                if (ripple.Size.Width + ripple.Inflate > ripple.MaxHeight)
                {
                    RippleList.Remove(ripple);
                }
            }
            //using (SolidBrush brush = new SolidBrush(BlueShade))
            //{
            //    using (Pen pen = new Pen(brush, 10))
            //    {
            //        for (int i = 0; i < RippleList.Count; i++)
            //        {
            //            Ripples ripple = RippleList[i];
            //            pen.Color = ripple.Color;
            //            ripple.Inflate += 15;

            //            if ((ripple.Size.Width < Width || ripple.Size.Height < Height) && ripple.Size.Width + ripple.Inflate <= ripple.MaxHeight)
            //            {
            //                int x = ripple.Location.X - ripple.LocationOffset - (ripple.Inflate / 2);
            //                int y = ripple.Location.Y - ripple.LocationOffset - (ripple.Inflate / 2);
            //                int width = ripple.Size.Width + ripple.Inflate;
            //                int height = ripple.Size.Height + ripple.Inflate;

            //                //e.Graphics.DrawArc(pen, x, y, width, height, 0, 360);
            //                //e.Graphics.DrawEllipse(pen, x, y, width, height);
            //                Brush b = new SolidBrush(Color.FromArgb(180, ripple.Color));
            //                e.Graphics.FillEllipse(b, x, y, width, height);
            //            }
            //            else
            //            {
            //                RippleList.Remove(ripple);
            //                i--;
            //            }
            //        }
            //    }
            //}
        }

        private void TimerTick(object sender, EventArgs e)
        {
            foreach(var point in RippleList)
            {
                if(timer == sender)
                {
                    if(point.Inflate < point.MaxHeight)
                    {
                        point.Inflate += 30;
                        if(alpha <= 50)
                        {
                            alpha = 80;
                        }
                        else
                        {
                            alpha -= 1;
                        }
                    }
                    else
                    {
                        timer.Stop();
                        //RippleList.Remove(point);
                        break;
                    }
                }
            }
            Invalidate();
        }
    }
}
