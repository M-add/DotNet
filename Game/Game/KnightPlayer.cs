using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Game
{
    public partial class KnightPlayer : Knights
    {
        private PictureBox Knight;
        private Timer timer;
        private int speed = 4;
        private Image standBy;

        public KnightPlayer(Image image)
        {
            InitializeComponent();
            DoubleBuffered = true;

            Size = new Size(75, 95);
            standBy = image;

            Knight = new PictureBox
            {
                Image = standBy,
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom,
            };

            timer = new Timer
            {
                Interval = 33,
            };
            timer.Tick += Update;
            Controls.Add(Knight);
            timer.Start();
            DoubleBuffered = true;
        }

        private void Update(object sender, EventArgs e)
        {
            if (Core.IsUp)
                Top -= speed;
            if (Core.IsDown)
                Top += speed;
            if (Core.IsLeft)
                Left -= speed;
            if (Core.IsRight)
                Left += speed;
        }

        public void RunRight()
        {
            Knight.Image = Properties.Resources.Right_Run;
        }
        public void RunLeft()
        {
            Knight.Image = Properties.Resources.Left_Run;
        }
        public void StandBy()
        {
            if (standBy != null)
            {
                Knight.Image = standBy;
            }
        }
    }
}
