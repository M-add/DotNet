using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form2 : Form
    {
        Form1 obj;
        public Form2()
        {
            InitializeComponent();
            obj = new Form1();
            this.WindowState = obj.WindowState;

            xoBox.PlayerTurns += Turns;
            xoBox.Winner += WinnerOfTheGame;
            FormClosed += FormShow;
        }
        private void FormShow(object sender, EventArgs e)
        {
            Hide();
            //obj.WindowState = WindowState;
            obj.ShowDialog();
        }
        private Size originalSize;
        private Rectangle BackSize;
        private Rectangle PlayeBoxSize;
        private Rectangle XoBoxSize;

        private void Form2_Load(object sender, EventArgs e)
        {
            originalSize = Size;
            BackSize = new Rectangle(Back.Location.X, Back.Location.Y, Back.Width, Back.Height);
            PlayeBoxSize = new Rectangle(PlayerBox.Location.X, PlayerBox.Location.Y, PlayerBox.Width, PlayerBox.Height);
            XoBoxSize = new Rectangle(xoPanel.Location.X, xoPanel.Location.Y, xoPanel.Width, xoPanel.Height);
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            //ResizeControl(BackSize, Back);
            //ResizeControl(PlayeBoxSize, PlayerBox);
            //ResizeControl(XoBoxSize, xoPanel);
        }  

        private void ResizeControl(Rectangle button, Control control)
        {
            float xAxis = Width / (float)(originalSize.Width);
            float yAxis = Height / (float)(originalSize.Height);

            int newXPosition = (int)(button.X * xAxis);
            int newYPosition = (int)(button.Y * yAxis);

            int newWidth = (int)(button.Width * xAxis);
            int newHeight = (int)(button.Height * yAxis);

            control.Location = new Point(newXPosition, newYPosition);
            control.Size = new Size(newWidth, newHeight);
        }
        public void Turns(object sender ,bool value)
        {
            if (value)
            {
                PlayerBox.Text = "Player 1's turn";
            }
            else
            {
                PlayerBox.Text = "Player 2's turn";
            }
        }

        private void WinnerOfTheGame(object sender,string s)
        {
            MessageBox.Show(s);
        }

        private void xoBox_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 Main = new Form1();
            //Main.WindowState = WindowState;
            Main.Show();
            Hide();          
        }

    }
}
