using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Snipping : Form
    {
        private Point StartingPoint;
        private Rectangle Selected;
        private bool isSnipping = false;

        public Snipping()
        {
            InitializeComponent();
            DoubleBuffered = true;
            BackColor = Color.White;
            Opacity = 0.5;
            TransparencyKey = Color.Green;

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Cursor = Cursors.Cross;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            StartingPoint = e.Location;
            isSnipping = true;
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (isSnipping)
            {
                Selected = new Rectangle(
                    Math.Min(StartingPoint.X, e.X),
                    Math.Min(StartingPoint.X, e.X),
                    Math.Abs(StartingPoint.X - e.X),
                    Math.Abs(StartingPoint.Y - e.Y));

                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if(isSnipping)
            {
                isSnipping = false;
                Bitmap bitmap = new Bitmap(Selected.Width, Selected.Height);
                Graphics graphis = Graphics.FromImage(bitmap);
                graphis.CopyFromScreen(Selected.Location, Point.Empty, Selected.Size);

                using (SaveFileDialog save = new SaveFileDialog())
                {
                    save.Title = "Save Dialog";
                    save.Filter = "(*PNG)|*.png";
                    if(save.ShowDialog() == DialogResult.OK)
                    {
                        string name = save.FileName;
                        bitmap.Save(name);
                        bitmap.GetPixel(0, 0);
                    }
                }
                Invalidate();

                if(MessageBox.Show("Do You Wanyt To Continue", "", MessageBoxButtons.YesNo) != DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (isSnipping)
            {
                using (Pen pen = new Pen(Color.Red, 2))
                {
                    pen.DashStyle = DashStyle.Dash;
                    e.Graphics.FillRectangle(Brushes.Green, Selected);
                    e.Graphics.DrawRectangle(pen, Selected);
                }
            }
        }
    }
}
