using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DragAndDrop
{
    public partial class Draw : Form
    {
        public Draw()
        {
            InitializeComponent();
        }

        private void DrawLoad(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void LogoPaint(object sender, PaintEventArgs e)
        {
            int width = Logo.Width;
            int height = Logo.Height;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            Brush brush = new SolidBrush(Color.FromArgb(5, 98, 176));

            PointF[] one = new PointF[4]
            {
                new PointF((width*50.8f)/100,(height * 2.6f)/100),
                new PointF((width*36.7f)/100,(height * 17.1f)/100),
                new PointF((width*58)/100,(height * 37)/100),
                new PointF((width*58)/100,(height * 10)/100)

            };
            e.Graphics.FillPolygon(brush, one);

            PointF[] two = new PointF[3]
            {
                new PointF((width*36.4f)/100,(height * 17.5f)/100),
                new PointF((width*13.7f)/100,(height * 40f)/100),
                new PointF((width*56.2f)/100,(height * 39.1f)/100)

            };
            e.Graphics.FillPolygon(brush, two);

            PointF[] three = new PointF[8]
            {
                new PointF((width*2.8f)/100,(height * 49.7f)/100),
                new PointF((width*12.4f)/100,(height * 41.1f)/100),
                new PointF((width*56f)/100,(height * 42f)/100),
                new PointF((width*31.1f)/100,(height * 66.9f)/100),
                new PointF((width*26.3f)/100,(height * 62.3f)/100),
                new PointF((width*21.1f)/100,(height * 58.5f)/100),
                new PointF((width*15.2f)/100,(height * 55.1f)/100),
                new PointF((width*8.6f)/100,(height * 52f)/100)
            };
            e.Graphics.FillPolygon(brush, three);

            PointF[] four = new PointF[13]
            {
                new PointF((width * 31.3f) / 100, (height * 67.2f) / 100),
                new PointF((width * 38.3f) / 100, (height * 76.3f) / 100),
                new PointF((width * 44f) / 100, (height * 83.1f) / 100),
                new PointF((width * 45.4f) / 100, (height * 86.2f) / 100),
                new PointF((width * 45.7f) / 100, (height * 86.8f) / 100),
                new PointF((width * 47.1f) / 100, (height * 89.1f) / 100),
                new PointF((width * 48.9f) / 100, (height * 91.7f) / 100),
                new PointF((width * 51.1f) / 100, (height * 98.3f) / 100),
                new PointF((width * 52.9f) / 100, (height * 94.2f) / 100),
                new PointF((width * 55f) / 100, (height * 90.2f) / 100),
                new PointF((width * 57.1f) / 100, (height * 86.9f) / 100),
                new PointF((width * 59.1f) / 100, (height * 84.6f) / 100),
                new PointF((width * 57.7f) / 100, (height * 44.6f) / 100)
            };
            e.Graphics.FillPolygon(brush, four);


        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);

            PictureBox pictureBox = (PictureBox)sender;

            Bitmap bitmap = new Bitmap(pictureBox.Image);

            Color pixel = bitmap.GetPixel(e.X, e.Y);
            BackColor = pixel;

            Invalidate();
        }
    }
}
