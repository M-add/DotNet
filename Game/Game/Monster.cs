using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Monster : UserControl
    {
        //public event EventHandler Defeated;
        //public PictureBox pic;
        public Monster(int x, int y)
        {
            InitializeComponent();
            DoubleBuffered = true;

            //pic = new PictureBox
            //{
            //    Size = pictureBox.Size,
            //    Image = pictureBox.Image,
            //    SizeMode = PictureBoxSizeMode.StretchImage
            //};

            Location = new Point(x, y);
        }

        public void OnTouch()
        {
            pictureBox.Image = Properties.Resources.defeat;
            Timer wait = new Timer()
            {
                Interval = 3000
            };
            wait.Tick += WaitTick;
            wait.Start();
        }

        private void WaitTick(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
