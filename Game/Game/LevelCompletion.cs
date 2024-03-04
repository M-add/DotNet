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
    public partial class LevelCompletion : Form
    {
        public LevelCompletion(TimeSpan elapsedTime)
        {
            InitializeComponent();
            DoubleBuffered = true;

            int Score = ((int)elapsedTime.TotalSeconds / Core.Enemies) * Core.Level;

            LevelLabel.Text = "Level" + Core.Level;
            ScoreLabel.Text = Score.ToString();

            Core.Monsters.Clear();

            RetryButton.DataBindings.Add("Size", ExitButton, "Size");
            NextButton.DataBindings.Add("Size", ExitButton, "Size");
        }

        public LevelCompletion()
        {
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RetryButtonClick(object sender, EventArgs e)
        {
            GameForm game = new GameForm(Core.player);
            game.WindowState = Core.GameState;
            Hide();
            game.Show();
        }

        private void NextButtonClick(object sender, EventArgs e)
        {
            Core.Level++;
            Core.Enemies += 5;
            GameForm game = new GameForm(Core.player);
            game.WindowState = Core.GameState;
            Hide();
            game.Show();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            ExitButton.Size = new Size((Width * 23) / 100, (Height * 29) / 100);
            ExitButton.Location = new Point((Width * 11) / 100, (Height * 49) / 100);
            RetryButton.Location = new Point((Width * 38) / 100, (Height * 49) / 100);
            NextButton.Location = new Point((Width * 65) / 100, (Height * 49) / 100);

            LevelLabel.Height = (Height * 23) / 100;
            ScoreLabel.Height = (Height * 23) / 100;
        }
    }
}
