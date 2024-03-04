using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDrop
{
    public partial class Form3 : Form
    {
        private int splitCount;
        private Rectangles[] subRectangles;
        private Color selectedColor = Color.LightBlue;
        private int count = 0;
        private bool clicked = false;
        private bool rotateRectangles = true;

        public Form3()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void RectanglePanelPaint(object sender, PaintEventArgs e)
        {
            DoubleBuffered = true;
            if (clicked)
            {
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, RectanglePanel.Width, RectanglePanel.Height);
                }


                foreach (var subRect in subRectangles)
                {
                    using (Brush brush = new SolidBrush(subRect.color))
                    {
                        e.Graphics.FillRectangle(brush, subRect.Location.X, subRect.Location.Y, subRect.size.Width, subRect.size.Height);
                        using (Pen pen = new Pen(Color.Black, 1))
                        {
                            e.Graphics.DrawRectangle(pen, subRect.Location.X, subRect.Location.Y, subRect.size.Width, subRect.size.Height);
                        }
                    }
                }
            }
        }

        private void SubmitClick(object sender, EventArgs e)
        {
            splitCount = int.Parse(SplitCountBox.Text);
            clicked = true;
            ColorButton.Visible = true;

            if (AngleBox.Text == "Vertical")
            {
                int subWidth = RectanglePanel.Width / splitCount;
                int subHeight = RectanglePanel.Height;

                for (int i = 0; i < splitCount; i++)
                {
                    subRectangles[i] = new Rectangles(i * subWidth, 0, subWidth, subHeight);
                }
            }
            else
            {
                int subWidth = RectanglePanel.Width;
                int subHeight = RectanglePanel.Height / splitCount;

                for (int i = 0; i < splitCount; i++)
                {
                    subRectangles[i] = new Rectangles(0, i * subHeight, subWidth, subHeight);
                }
            }
            RectanglePanel.Invalidate();
        }

        private void RectanglePanelMouseClick(object sender, MouseEventArgs e)
        {
            foreach (var rect in subRectangles)
            {
                if (e.X >= rect.Location.X && e.X <= rect.Location.X + rect.size.Width && e.Y >= rect.Location.Y && e.Y <= rect.Location.Y + rect.size.Height)
                {
                    rect.color = selectedColor;
                }
            }
            RectanglePanel.Invalidate();
        }

        private void ColorButtonClick(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedColor = colorDialog.Color;
                }
            }
        }

        private void AngleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rotateRectangles = !rotateRectangles;
        }
    }
    public class Rectangles
    {
        public Size size { get; set; }
        public Point Location { get; set; }
        public Rectangle rectangle { get { return new Rectangle(Location, size); } }
        public Color color { get; set; } = Color.LightBlue;

        public Rectangles(int x, int y, int width, int height)
        {
            Location = new Point(x, y);
            size = new Size(width, height);
        }
    }
}


