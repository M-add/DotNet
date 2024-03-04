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
    public partial class GameList : Form
    {
        public GameList()
        {
            InitializeComponent();
        }

        private void GameOne_Click(object sender, EventArgs e)
        {
            Form1 GameOne = new Form1();
            GameOne.Show();
            Hide();
        }

        private void GameTwo_Click(object sender, EventArgs e)
        {
            SnakeGame GameTwo = new SnakeGame();
            GameTwo.Show();
            Hide();
        }

        private List<Form> displayedForms = new List<Form>();

        static int x = Screen.PrimaryScreen.WorkingArea.Right - 300;
        static int y = Screen.PrimaryScreen.WorkingArea.Bottom - 300;

        private Point nextFormLocation = new Point(x, y);
        private void roundButton1_Click(object sender, EventArgs e)
        {
            Form newForm = new Form();
            newForm.StartPosition = FormStartPosition.Manual;


            newForm.Location = nextFormLocation;
            newForm.Show();

            nextFormLocation.Offset(0, -300);
            displayedForms.Add(newForm);
        }

        private void DodgeGameClick(object sender, EventArgs e)
        {
            Escape dodge = new Escape();
            dodge.StartPosition = FormStartPosition.CenterScreen;
            dodge.Show();
            Hide();
        }
    }
}
