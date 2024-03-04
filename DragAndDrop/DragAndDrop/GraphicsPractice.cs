using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DragAndDrop
{
    public partial class GraphicsPractice : Form
    {
        //private Point loc;

        public GraphicsPractice()
        {
            InitializeComponent();

            //loc = car.Location;
            //KeyDown += GraphicsPracticeKeyDown;
            //KeyPreview = true;
        }

        private void GraphicsPractice_Load(object sender, EventArgs e)
        {
        }

        private void GraphicsPracticeResize(object sender, EventArgs e)
        {
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            Bitmap bitmap = new Bitmap(pic.Image);

            Color color = bitmap.GetPixel(e.X, e.Y);

            FillPanel.BackColor = color;
        }

        private void GraphicsPractice_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private Color GetPixelColor(Point location)
        {
            Bitmap screenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                           Screen.PrimaryScreen.Bounds.Height);

            Graphics graphics = Graphics.FromImage(screenshot);
            graphics.CopyFromScreen(location, location, new Size(1, 1), CopyPixelOperation.SourceCopy);

            return screenshot.GetPixel(location.X, location.Y);
        }

        private void GraphicsPractice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.X)
            {
                Point cursorPosition = Cursor.Position;
                Color pixel = GetPixelColor(cursorPosition);
                FillPanel.BackColor = pixel;
            }
        }
        //private void GraphicsPracticeKeyDown(object sender, KeyEventArgs e)
        //{

        //    switch (e.KeyCode)
        //    {
        //        case Keys.A:
        //            if (loc.X - 10 > 0)
        //            {
        //                MoveCarLeft();
        //            }
        //            break;
        //        case Keys.D:
        //            if (loc.X + car.Width <= ClientSize.Width)
        //            {
        //                MoveCarRight();
        //            }
        //            break;
        //        case Keys.W:
        //            if (loc.Y - 10 > 0)
        //            {
        //                MoveCarUp();
        //            }
        //            break;
        //        case Keys.S:
        //            if (loc.Y + car.Height <= ClientSize.Height)
        //            {
        //                MoveCarDown();
        //            }
        //            break;
        //    }
        //}

        //private void MoveCarLeft()
        //{
        //    loc.X -= 10;
        //    car.Location = loc;
        //}

        //private void MoveCarRight()
        //{
        //    loc.X += 10;
        //    car.Location = loc;
        //}

        //private void MoveCarUp()
        //{
        //    loc.Y -= 10;
        //    car.Location = loc;
        //}

        //private void MoveCarDown()
        //{
        //    loc.Y += 10;
        //    car.Location = loc;
        //}
    }
}
