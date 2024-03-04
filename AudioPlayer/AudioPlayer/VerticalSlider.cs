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

namespace AudioPlayer
{
    public partial class VerticalSlider : UserControl
    {
        public event EventHandler<float> ValueChanged;

        private PictureBox pic;

        private float value;
        public float Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
                Invalidate();
            }
        }
        public float Minimum { get; set; } = 0f;
        public float Maximum { get; set; } = 0f;

        private float CurrentValue;
        private bool isDragging = false;

        public VerticalSlider()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Value = CurrentValue = Height;
        }

        protected virtual void OnValueChanged(float value)
        {
            float volume = ((Height - value) / Height) * 100;
            ValueChanged?.Invoke(this, volume);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            //Pen pen = new Pen(Color.Black , 1);
            Brush brush = new SolidBrush(Color.FromArgb(197, 198, 224));
            Brush fillBrush = new SolidBrush(Color.FromArgb(3, 124, 249));

            pic = new PictureBox()
            {
                Image = Properties.Resources.Musicpng,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size((Width * 50) / 100, (Width * 50) / 100),
                Location = new Point(Width / 4, Height - Width),
                BackColor = Color.Transparent
            };

            float cornerRadius = (Width * 43.5f) / 100;
            Rectangle Top = new Rectangle(0, 0, (Width * 97) / 100, Height / 2);
            Rectangle Bottom = new Rectangle(0, Height / 2, (Width * 97) / 100, (Height * 49) / 100);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(Top.Left, Top.Top, cornerRadius * 2, cornerRadius * 2, 180, 90);
            path.AddArc(Top.Right - cornerRadius * 2, Top.Top, cornerRadius * 2, cornerRadius * 2, 270, 90);
            path.AddArc(Bottom.Right - cornerRadius * 2, Bottom.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            path.AddArc(Bottom.Left, Bottom.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            path.CloseFigure();

            e.Graphics.FillPath(brush, path);
            //e.Graphics.DrawPath(pen, path);

            Controls.Add(pic);

            Region region = new Region(path);
            RectangleF fill = new RectangleF(1, Value, (Width * 96) / 100, Height);
            region.Intersect(fill);
            e.Graphics.FillRegion(fillBrush, region);

            PointF percentPoint = new PointF(Width / 3, (Height * 8) / 100);
            Font font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            int percentage = (int)(((Height - Value) / Height) * 100);
            if (percentage < 0) percentage = 0;
            if (percentage > 99) percentPoint.X = Width / 4;
            if (percentage == 0) percentPoint.X = Width / 2.5F;
            e.Graphics.DrawString(percentage.ToString(), font, Brushes.Black, percentPoint);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            isDragging = true;

            Value = e.Y;
            Invalidate();
            OnValueChanged(value);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            isDragging = false;
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (isDragging && e.Y >= 0)
            {
                Value = e.Y;
                Invalidate();
                OnValueChanged(value);
            }
        }
    }
}
