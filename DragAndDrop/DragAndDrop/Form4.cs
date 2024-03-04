using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Newtonsoft;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Net.Http;
using System.Drawing.Drawing2D;
using DragAndDrop.Properties;
using System.Collections;
using System.Globalization;
using System.Reflection;

namespace DragAndDrop
{
    public partial class Form4 : Form
    {
        Dictionary<int, PictureBox> Data = new Dictionary<int, PictureBox>();
        List<Image> Images = new List<Image>();

        public Form4()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += TickEvent;
            timer.Start();

            LoadDatabase();
        }
        private void LoadDatabase()
        {
            for (int i = 1; i <= 10; i++)
            {
                string s = "image" + i;
                Images.Add((Resources.ResourceManager.GetObject(s) as Bitmap));
            }

            for (int i = 0; i < 10; i++)
            {
                PictureBox pic = new PictureBox
                {
                    Image = Images[i],
                    SizeMode = PictureBoxSizeMode.Zoom
                };

                Data[i] = pic;
            }
        }
        private void TickEvent(object sender, EventArgs e)
        {
            TimeShow();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void TimeShow()
        {
            label1.Text = clock.Time();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            show.Controls.Clear();

            Random rand = new Random();
            int index = rand.Next(0, Images.Count);

            show.Controls.Add(Data[index]);
            Data[index].Dock = DockStyle.Fill;
        }

        //private void panel4_Paint(object sender, PaintEventArgs e)
        //{
        //    int x = panel4.Width / 5;
        //    int y = 0;
        //    int r = panel4.Height;
        //    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        //    e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
        //    //e.Graphics.DrawEllipse(new Pen(Color.Black), new RectangleF(50, 50, 30, 30));
        //    e.Graphics.FillEllipse(new LinearGradientBrush(new PointF(100, r), new PointF(10, Height),
        //        Color.Crimson, Color.MediumVioletRed),
        //        new RectangleF(x, y, r, r));

        //}
    }
}