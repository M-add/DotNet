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
    public partial class VolumeSlider : UserControl
    {
        public event EventHandler<float> ValueChanged;

        private float sliderValue = 0f;
        public float SliderValue
        { 
            get { return sliderValue; }
            set
            {
                if(value > Max)
                {
                    sliderValue = Max;
                }
                else
                {
                    sliderValue = value;
                }
                Invalidate();
            }
        }

        public float Min { get; set; } = 0F;
        public float Max { get; set; } = 100.0F;

        public VolumeSlider()
        {
            InitializeComponent();
            //BackColor = Color.Green;
        }

        protected virtual void OnValueChanged(float value)
        {
            ValueChanged?.Invoke(this, value);
        }

        public float Bar(float value)
        {
            return ((Width * 95)/100) * (value - Min) / (float)(Max - Min);
        }

        public void Thumb(float value)
        {
            if (value < Min) value = Min;
            if (value > Max) value = Max;
            sliderValue = value;
            Invalidate();

            OnValueChanged(sliderValue);
        }

        public float SliderWidth(int x)
        {
            return Min + (Max - Min) * x / (float)Width;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int x = (int)Bar(sliderValue);
            int y = Height / 4;


            DoubleBuffered = true;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            GraphicsPath path = new GraphicsPath();

            Rectangle left = new Rectangle(2, Height / 3, Height - 2, Height / 3);
            Rectangle right = new Rectangle(Width - Height, Height / 3, Height / 2, Height / 3);

            path.StartFigure();
            path.AddArc(left, 90, 180);
            path.AddArc(right, 270, 180);
            path.CloseFigure();
            //e.Graphics.FillPath(Brushes.Blue, path);
            e.Graphics.DrawPath(new Pen(Color.SlateBlue, 3), path);

            Pen pens = new Pen(Color.DimGray, 2);
            //pens.StartCap = pens.EndCap = LineCap.Round;

            //Rectangle Bar = new Rectangle(2, 1, (Height * 90) / 100, (Height * 90) / 100);
            //e.Graphics.DrawEllipse(pen, Bar);
            //e.Graphics.FillEllipse(Brushes.Silver, Bar);

            //e.Graphics.FillRectangle(Brushes.Red, 3, Height / 3, x, Height / 3);
            GraphicsPath fill = CreateRoundedRectangle(3, (Height * 35) / 100, x, (Height * 27.5f) / 100, 4.5f);
            e.Graphics.FillPath(Brushes.Violet, fill);

            using (Pen pen = new Pen(Color.Black, 10))
            {
                e.Graphics.FillEllipse(Brushes.White, x, (Height*10)/100, (Height * 90) / 100, (Height * 90) / 100);
            }
        }

        private GraphicsPath CreateRoundedRectangle(float x, float y, float width, float height, float radius)
        {
            GraphicsPath path = new GraphicsPath();

            float diameter = radius * 2;

            RectangleF arcRect = new RectangleF(x, y, diameter, diameter);
            path.AddArc(arcRect, 180, 90);

            arcRect.X = x + width - diameter;
            path.AddArc(arcRect, 270, 90);

            arcRect.Y = y + height - diameter;
            path.AddArc(arcRect, 0, 90);

            arcRect.X = x;
            path.AddArc(arcRect, 90, 90);

            path.CloseFigure();

            return path;
        }

        bool mouse = false;
        private void VolumeSlider_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void VolumeSlider_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                Thumb(SliderWidth(e.X));
            }
        }

        private void VolumeSlider_MouseDown(object sender, MouseEventArgs e)
        {
            //if (!mouse) return;
            mouse = true;
            Thumb(SliderWidth(e.X));
        }
    }
}
