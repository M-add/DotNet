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
    public partial class CustomRadioButton : UserControl
    {
        private bool check = true;
        private Color CheckedColor = Color.MediumSlateBlue;
        private Color UnCheckedColor = Color.Gray;
        private string text = "Text Area";
        private Color textAreaColor;

        //private Timer timer = new Timer();

        public Color TextAreaColor
        {
            get
            {
                return textAreaColor;
            }
            set
            {
                textAreaColor = value;
                TextArea.Invalidate();
            }
        }
        public string TextBox
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                TextArea.Invalidate();
            }
        }

        public bool Check
        {
            get
            {
                return check;
            }
            set
            {
                check = value;
                RadioPanel.Invalidate();
            }
        }
        public Color Checked
        {
            get
            {
                return CheckedColor;
            }
            set
            {
                CheckedColor = value;
                RadioPanel.Invalidate();
            }
        }
        public Color UnChecked
        {
            get
            {
                return UnCheckedColor;
            }
            set
            {
                UnCheckedColor = value;
                RadioPanel.Invalidate();
            }
        }

        public CustomRadioButton()
        {
            InitializeComponent();

            //timer.Interval = 16;
            //timer.Tick += TimerTick;
        }

        //public int circleSpace = 1;
        //private void TimerTick(object sender, EventArgs e)
        //{
        //    circleSpace += 10;
        //    RadioPanel.Invalidate();

        //    if (circleSpace > RadioPanel.Width / 10)
        //    {
        //        timer.Stop();
        //        circleSpace = 10;
        //    }
        //}

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void RadioPanelPaint(object sender, PaintEventArgs e)
        {
            DoubleBuffered = true;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighSpeed;

            Rectangle outer = new Rectangle(RadioPanel.Margin.Left,
                RadioPanel.Margin.Top,
                RadioPanel.Width - RadioPanel.Margin.Left - RadioPanel.Margin.Right,
                RadioPanel.Height - RadioPanel.Margin.Top - RadioPanel.Margin.Bottom);

            e.Graphics.DrawEllipse(new Pen(CheckedColor, 3), outer);

            int circleSpace = RadioPanel.Width / 10;
            Rectangle circle = new Rectangle(RadioPanel.Margin.Left + circleSpace,
                    RadioPanel.Margin.Top + circleSpace,
                    RadioPanel.Width - RadioPanel.Margin.Left - RadioPanel.Margin.Right - circleSpace * 2,
                    RadioPanel.Height - RadioPanel.Margin.Top - RadioPanel.Margin.Bottom - circleSpace * 2);

            if (check)
            {
                e.Graphics.FillEllipse(new SolidBrush(Checked), circle);
            }
            else
            {
                e.Graphics.DrawEllipse(new Pen(UnCheckedColor, 3), outer);
            }
        }

        private void RadioPanelClick(object sender, EventArgs e)
        {
            check = !check;
            //timer.Start();
            RadioPanel.Invalidate();
        }

        private void TextAreaPaint(object sender, PaintEventArgs e)
        {
            DoubleBuffered = true;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighSpeed;
            GraphicsPath path = new GraphicsPath();

            int rightPanelX = RadioPanel.Right;
            int width = TextArea.Width - 5;
            int height = TextArea.Height - 5;

            PointF TopLeft = new PointF(5, 5);
            PointF TopRight = new PointF(width, 5);
            PointF BottomLeft = new PointF(5, height);
            PointF BottomRight = new PointF(width, height);

            path.StartFigure();
            path.AddLine(TopLeft, TopRight);
            path.AddLine(TopRight, BottomRight);
            path.AddLine(BottomRight, BottomLeft);
            path.AddLine(BottomLeft, TopLeft);
            path.CloseFigure();

            e.Graphics.DrawPath(new Pen(Color.Black, 5), path);
            e.Graphics.FillPath(new SolidBrush(textAreaColor), path);

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString(TextBox, Font, new SolidBrush(ForeColor), new RectangleF(0, 0, width, height), format);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            RadioPanel.Width = Width / 3;
        }
    }
}
