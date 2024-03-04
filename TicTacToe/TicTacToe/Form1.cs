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

namespace TicTacToe
{
    public partial class Form1 : Form
    {     
        public Form1()
        {
            InitializeComponent();      
        }

        private Size originalSize;
        private Rectangle PicturePanelSize;
        private Rectangle PlaySize;
        private Rectangle ExitSize;
        private Rectangle NoteSize;

        private void Form1_Load(object sender, EventArgs e)
        {
            RoundButton CurvyButton = new RoundButton();
            Controls.Add(CurvyButton);

            originalSize = this.Size;
            PicturePanelSize = new Rectangle(PicturePanel.Location.X, PicturePanel.Location.Y, PicturePanel.Width, PicturePanel.Height);
            PlaySize = new Rectangle(PlayButton.Location.X, PlayButton.Location.Y, PlayButton.Width, PlayButton.Height);
            ExitSize = new Rectangle(ExitButton.Location.X, ExitButton.Location.Y, ExitButton.Width, ExitButton.Height);
            NoteSize = new Rectangle(NoteLabel.Location.X, NoteLabel.Location.Y, NoteLabel.Width, NoteLabel.Height);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeControl(PicturePanelSize, PicturePanel);
            ResizeControl(PlaySize, PlayButton);
            ResizeControl(ExitSize, ExitButton);
            ResizeControl(NoteSize, NoteLabel);
        }

        private void ResizeControl(Rectangle button, Control control)
        {
            float xAxis = (float)(Width) / (float)(originalSize.Width);
            float yAxis = (float)(Height) / (float)(originalSize.Height);

            int newXPosition = (int)(button.X * xAxis);
            int newYPosition = (int)(button.Y * yAxis);

            int newWidth = (int)(button.Width * xAxis);
            int newHeight = (int)(button.Height * yAxis);

            control.Location = new Point(newXPosition, newYPosition);
            control.Size = new Size(newWidth, newHeight);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Form2 game = new Form2();
            this.Hide();
            game.WindowState = WindowState;
            game.ShowDialog();
        }
        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.Crimson;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton_MouseMove(object sender, MouseEventArgs e)
        {
            ExitButton.BackColor = Color.Red;
        }

        private void PlayButton_MouseMove(object sender, MouseEventArgs e)
        {
            PlayButton.BackColor = Color.CornflowerBlue;
        }

        private void PlayButton_MouseLeave(object sender, EventArgs e)
        {
            PlayButton.BackColor = Color.DodgerBlue;
        }

    }
}
