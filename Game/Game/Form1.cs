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
    public partial class Form1 : Form
    {
        private Image choosenKnight;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void PlayButtonClick(object sender, EventArgs e)
        {
            if (choosenKnight != null)
            {
                KnightPlayer player = new KnightPlayer(choosenKnight);
                Core.player = player;
                GameForm game = new GameForm(player);
                game.WindowState = WindowState;
                game.Show();
                game.Shown += GameShown;
            }
        }

        private void GameShown(object sender, EventArgs e)
        {
            Hide();
        }

        private void OnClickKnight(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            choosenKnight = pic.Image;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Core.FormState = WindowState;

            pictureBox1.Width = pictureBox2.Width = pictureBox3.Width = pictureBox4.Width = (MainPanel.Width * 25) / 100;
            KnightPanel.Height = (MainPanel.Height * 47) / 100;

            //pictureBox1.Location = new Point(0, 0);
            //pictureBox2.Location = new Point((KnightPanel.Width * 25)/100, 0);
            //pictureBox3.Location = new Point((KnightPanel.Width * 50)/100, 0);
           // pictureBox3.Location = new Point((KnightPanel.Width * 75)/100, 0);

            PlayButton.Location = new Point((MainPanel.Width * 36) / 100, (MainPanel.Height * 72) / 100);
            PlayButton.Size = new Size((MainPanel.Width * 30) / 100, (MainPanel.Height * 20) / 100);
        }

    }
}
