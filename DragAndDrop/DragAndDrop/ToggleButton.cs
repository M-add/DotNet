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
    public partial class ToggleButton : UserControl
    {
        private Color onColor = Color.ForestGreen;
        private Color offColor = Color.Red;
        private Color toggleColor = Color.White;
        private Color borderColor = Color.Black;

        private int toggleSize;
        public bool stateChecked = true;
        private Rectangle toggle;
        private int endPoint;
        private int startPoint;
        private Timer transitionTimer;

        //public event EventHandler<bool> ToggleOrNot;

        public Color OnColor
        {
            set
            {
                onColor = value;
                Invalidate();
            }
            get { return onColor; }
        }
     
        public Color OffColor
        {
            set
            {
                offColor = value;
                Invalidate();
            }
            get { return offColor; }
        }
        public Color ToggleColor
        {
            set
            {
                toggleColor = value;
                Invalidate();
            }
            get { return toggleColor; }
        }
        public Color BorderColor
        {
            set
            {
                borderColor = value;
            }
            get
            {
                Invalidate();
                return borderColor;
            }
        }
        public bool State
        {
            set
            {
                stateChecked = value;
                Invalidate(); 
            }
            get
            {
                return stateChecked;
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
        }

        public ToggleButton()
        {
            InitializeComponent();
            MinimumSize = new Size(40, 20);

            if (!stateChecked)
                toggle = new Rectangle(0, 0, toggleSize, toggleSize);
            else
                toggle = new Rectangle(Width - Height, 2, toggleSize, toggleSize);

            Invalidate();
        }

        private GraphicsPath GetFigurePath()
        {
            //SuspendLayout();
            int arcWidth = Height - 1;
            int arcHeight = Height - 2;

            Rectangle leftArc = new Rectangle(0, 0, arcWidth, arcHeight);
            Rectangle rightArc = new Rectangle(endPoint, 0, arcWidth, arcHeight);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();
            //ResumeLayout();

            return path;
        }

        private GraphicsPath BorderPath()
        {
            int arcWidth = Height - 3;
            int arcHeight = Height - 4;

            Rectangle leftArc = new Rectangle(2, 2, arcWidth, arcHeight);
            Rectangle rightArc = new Rectangle(Width - Height - 4, 1 , arcWidth, arcHeight);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }
        private void IncrementMethod(Object Sender, EventArgs e)
        {
            int incrementRatio = Width / 18;
            startPoint = 4;

            if (stateChecked)
            {
                if (toggle.X < endPoint)
                {
                    toggle.X += incrementRatio;
                }
                else
                {
                    toggle.X = endPoint;
                    transitionTimer.Stop();
                }
            }
            else
            {
                if (toggle.X > startPoint)
                {
                    toggle.X -= incrementRatio;
                }
                else
                {
                    toggle.X = startPoint;
                    transitionTimer.Stop();
                }
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs args)
        {
            DoubleBuffered = true;

            toggle.Width = toggleSize;
            toggle.Height = toggleSize;

            Graphics g = args.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(this.Parent.BackColor);

            using (Pen pen = new Pen(borderColor, 5))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                g.FillPath(new SolidBrush(stateChecked ? onColor : offColor), GetFigurePath());
                g.DrawPath(pen, BorderPath());
            }
            if(stateChecked)
            {
                g.FillEllipse(new SolidBrush(toggleColor), toggle.X + 3, toggle.Y + 3, toggle.Width - 6, toggle.Height - 8);
            }
            else
            {
                g.FillEllipse(new SolidBrush(toggleColor), toggle.X + 3, toggle.Y + 4 , toggle.Width - 6, toggle.Height - 8);
            }
        }

        private void ToggleButton_Load(object sender, EventArgs e)
        {
            toggleSize = Height - 5;
            endPoint = Width - Height - 4;
            toggle.X = endPoint;
        }

        public void ToggleButton_MouseClick(object sender, MouseEventArgs e)
        {
            stateChecked = !stateChecked;

            //PaintEventArgs args = new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle);

            transitionTimer = new Timer();
            transitionTimer.Interval = 1;
            transitionTimer.Tick += IncrementMethod;
            transitionTimer.Start();

            //ToggleOrNot?.Invoke(this, stateChecked);
        }

        private void ToggleButtonResize(object sender, EventArgs e)
        {
            toggleSize = Height - 5;
            endPoint = Width - Height - 4;
            toggle.X = endPoint;
        }
    }
}
