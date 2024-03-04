using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDrop
{
    public partial class DynamicDrawing : UserControl
    {
        private Point location = new Point(0, 0);
        private string Angle;
        private bool isClicked = false;
        private int Value = 0;
        List<InnerRectangle> RectangleList = new List<InnerRectangle>();
        private ColorDialog colorDialog;

        public DynamicDrawing()
        {
            InitializeComponent();
            //MinimumSize = new Size(300, 80);
            colorDialog = new ColorDialog();
            ColorButton.Click += ColorButtonClick;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            InputPanel.Width = Width / 4;
            ColorButton.Width = button1.Width = DropDown.Width = NumberBox.Width = SubmitButton.Width = InputPanel.Width / 2;

            int reqHeight = Height / 6;
            ColorButton.Height = button1.Height = SubmitButton.Height = NumberBox.Height = DropDown.Height;

            ColorButton.Location = DropDown.Location = new Point(InputPanel.Width / 4, reqHeight);
            NumberBox.Location = new Point(InputPanel.Width / 4, 3 * reqHeight);
            button1.Location = SubmitButton.Location = new Point(InputPanel.Width / 4, 5 * reqHeight);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (isClicked)
            {
                Angle = DropDown.SelectedItem.ToString();
                if (Angle.ToString().Equals("Vertical"))
                {
                    for (int i = 0; i < Value; i++)
                    {
                        VerticalDrawer(e);
                        if (location.X > (Width-panel1.Width)) break;
                    }
                }
                else for (int i = 0; i < Value; i++) HorizontalDrawer(e);
                isClicked = !isClicked;
                location = new Point(0, 0);
            }
            RectanglesDrawer(e);
        }

        private int RequiredOperation;
        private void VerticalDrawer(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int drawableWidth = (Width / 4 * 3) / Value;
            if (RequiredOperation > 0)
            {
                InnerRectangle r = RectangleList[RectangleList.Count - RequiredOperation--];
                r.Location = new Point(location.X + 1, location.Y + 1);
                r.Size = new Size(drawableWidth - 2, Height - 2);
            }
            else
            {
                InnerRectangle r = new InnerRectangle
                {
                    Location = new Point(location.X + 1, location.Y + 1),
                    Size = new Size(drawableWidth - 2, Height - 2),
                };
                RectangleList.Add(r);
            }
            location.X += drawableWidth;
        }

        private void HorizontalDrawer(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int drawableHeight = Height / Value;
            if (RequiredOperation > 0)
            {
                InnerRectangle rectangle = RectangleList[RectangleList.Count - RequiredOperation--];
                rectangle.Location = new Point(location.X + 1, location.Y + 1);
                rectangle.Size = new Size((Width / 4) * 3  , drawableHeight - 2);
            }
            else
            {
                InnerRectangle rectangle = new InnerRectangle
                {
                    Location = new Point(location.X + 1, location.Y + 1),
                    Size = new Size((Width / 4) * 3 - 2, drawableHeight - 2),
                };
                RectangleList.Add(rectangle);
            }
            location.Y += drawableHeight;
        }

        private void RectanglesDrawer(PaintEventArgs e)
        {
            for (int i = 0; i < Value; i++)
            {
                e.Graphics.DrawRectangle(new Pen(RectangleList[i].Color,1), RectangleList[i].Rect);
                e.Graphics.FillRectangle(new SolidBrush(RectangleList[i].Color), RectangleList[i].Rect);
            }
            
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            isClicked = true;

            Value = int.Parse(NumberBox.Text);
            RequiredOperation = RectangleList.Count;
            Width = Width + ((Width / 4 * 3) % Value);
            Height = Height + (Height % Value);

            Invalidate();
        }
        private InnerRectangle rect;

        private void DynamicDrawing_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var rect in RectangleList)
            {
                if ((e.Location.X >= rect.Location.X && e.Location.X <= rect.Location.X + rect.Size.Width) &&
                    ((e.Location.Y >= rect.Location.Y && e.Location.Y <= rect.Location.Y + rect.Size.Height)))
                {
                    panel1.BringToFront();
                    this.rect = rect;
                }
            }
        }
        private Color selectedColor;
        private void ColorButtonClick(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                selectedColor = colorDialog.Color;
                ColorButton.BackColor = selectedColor;
                Invalidate();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rect.Color = selectedColor;
            panel1.SendToBack();
            Invalidate();
        }
    }
    class InnerRectangle
    {
        public Size Size { get; set; }
        public Point Location { get; set; }
        public Rectangle Rect { get { return new Rectangle(Location, Size); } }
        public Color Color { get; set; } = Color.LightBlue;
    }
}
