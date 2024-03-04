using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace Graphics
{
    public class Toggle : CheckBox
    {
        private Color onBackColor = Color.LawnGreen;
        private Color offBackColor = Color.Crimson;
        private Color onToggleColor = Color.Azure;
        private Color offToggleColor = Color.WhiteSmoke;

        public Color OnBackColor
        {
            get
            {
                return onBackColor;
            }
            set
            {
                onBackColor = value;
                this.Invalidate();
            }
        }
        public Color OffBackColor
        {
            get => offBackColor;
            set
            {
                offBackColor = value;
                this.Invalidate();
            }
        }
        public Color OnToggleColor
        {
            get => onToggleColor;
            set
            {
                onToggleColor = value;
                this.Invalidate();
            }
        }
        public Color OffToggleColor
        {
            get => offToggleColor; set
            {
                offToggleColor = value;
                this.Invalidate();
            }
        }

        protected override void OnAutoSizeChanged(EventArgs e)
        {
            base.OnAutoSizeChanged(e);
            this.AutoSize = false;
        }
        public Timer time;
        public Toggle()
        {
            this.MinimumSize = new Size(55, 32);
            time = new Timer();
            time.Interval = 6000;
            time.Tick += Ttansition;
            time.Start();
        }

        private void Ttansition(object sender, EventArgs e)
        {
            time.Stop();
        }

        private GraphicsPath GetGraphicsPath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle righttArc = new Rectangle(this.Width - arcSize, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(righttArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            // base.OnPaint(pevent);
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked)
            {
                pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetGraphicsPath());

                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor),
                    new Rectangle(this.Width - this.Height, 2, toggleSize, toggleSize));
            }
            else
            {
                pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetGraphicsPath());

                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor),
                    new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}