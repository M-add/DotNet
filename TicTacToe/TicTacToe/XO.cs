using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class XO : UserControl
    {
        public event EventHandler<bool> PlayerTurns;
        public event EventHandler<string> Winner;
        Label[] Labels;

        public XO()
        {
            InitializeComponent(); 
        }
        
        public bool PlayerTurn = true;
        private int count = 0;
        private string[,] XoMatrix = new string[3, 3];

        private void XO_Load(object sender, EventArgs e)
        {
            Labels = new Label[] { label1, label2, label3, label4, label5, label6, label7, label8, label9 };
            Rectangle Window = Screen.PrimaryScreen.WorkingArea;
            this.Size = new Size((int)(0.5 * Window.Width), (int)(0.5 * Window.Height));
            this.Location = new Point(50, 50);
        }      

        private void Check()
        {
            for (int i = 0; i < 3; i++)
            {
                if (XoMatrix[i, 0] == XoMatrix[i, 1] && XoMatrix[i, 1] == XoMatrix[i, 2] && !string.IsNullOrEmpty(XoMatrix[i, 0]))
                {
                    //MessageBox.Show($"{XoMatrix[i, 0]} wins!");
                    Winner?.Invoke(this, $"{XoMatrix[i, 0]} wins!");
                    ResetGame();
                    return;
                }
                else if (XoMatrix[0, i] == XoMatrix[1, i] && XoMatrix[1, i] == XoMatrix[2, i] && !string.IsNullOrEmpty(XoMatrix[0, i]))
                {
                    //MessageBox.Show($"{XoMatrix[0, i]} wins!");
                    Winner?.Invoke(this, $"{XoMatrix[0, i]} wins!");
                    ResetGame();
                    return;
                }
            }

            if (XoMatrix[0, 0] == XoMatrix[1, 1] && XoMatrix[1, 1] == XoMatrix[2, 2] && !string.IsNullOrEmpty(XoMatrix[0, 0]))
            {
                //MessageBox.Show($"{XoMatrix[0, 0]} wins!");
                Winner?.Invoke(this, $"{XoMatrix[0, 0]} wins!");
                ResetGame();
                return;
            }

            if (XoMatrix[0, 2] == XoMatrix[1, 1] && XoMatrix[1, 1] == XoMatrix[2, 0] && !string.IsNullOrEmpty(XoMatrix[0, 2]))
            {
               // MessageBox.Show($"{XoMatrix[0, 2]} wins!");
                Winner?.Invoke(this, $"{XoMatrix[0, 2]} wins!");
                ResetGame();
                return;
            }

            if (count == 9)
            {
                //MessageBox.Show("It's a tie!");
                Winner?.Invoke(this, "It's a tie!");
                ResetGame();
            }
        }

        private void ResetGame()
        {
            PlayerTurn = true;
            count = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    XoMatrix[i, j] = null;
                }
            }

            foreach (Label label in Labels)
            {
                label.Text = "";
            }

            PlayerTurns?.Invoke(this, PlayerTurn);
        }


        private void ChangeTurns()
        {
            if (PlayerTurn)
            {
                PlayerTurn = false;
            }
            else
            {
                PlayerTurn = true;
            }
            count++;
            PlayerTurns?.Invoke(this, PlayerTurn);
            Check();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (count < 9 && XoMatrix[0,0] == null)
            {
                if (PlayerTurn)
                {
                    label1.Text = "X";
                }
                else
                {
                    label1.Text = "O";
                }
                XoMatrix[0, 0] = label1.Text;
                ChangeTurns();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (count < 9 && XoMatrix[0, 1] == null)
            {
                if (PlayerTurn)
                {
                    label2.Text = "X";
                }
                else
                {
                    label2.Text = "O";
                }
                XoMatrix[0, 1] = label2.Text;
                ChangeTurns();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (count < 9 && XoMatrix[0, 2] == null)
            {
                if (PlayerTurn)
                {
                    label3.Text = "X";
                }
                else
                {
                    label3.Text = "O";
                }
                XoMatrix[0, 2] = label3.Text;
                ChangeTurns();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (count < 9 && XoMatrix[1, 0] == null)
            {
                if (PlayerTurn)
                {
                    label4.Text = "X";
                }
                else
                {
                    label4.Text = "O";
                }
                XoMatrix[1, 0] = label4.Text;
                ChangeTurns();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (count < 9 && XoMatrix[1, 1] == null) 
            {
                if (PlayerTurn)
                {
                    label5.Text = "X";
                }
                else
                {
                    label5.Text = "O";
                }
                XoMatrix[1, 1] = label5.Text;
                ChangeTurns();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (count < 9 && XoMatrix[1, 2] == null) 
            {
                if (PlayerTurn)
                {
                    label6.Text = "X";
                }
                else
                {
                    label6.Text = "O";
                }
                XoMatrix[1, 2] = label6.Text;
                ChangeTurns();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (count < 9 && XoMatrix[2, 0] == null)
            {
                if (PlayerTurn)
                {
                    label7.Text = "X";
                }
                else
                {
                    label7.Text = "O";
                }
                XoMatrix[2, 0] = label7.Text;
                ChangeTurns();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (count < 9 && XoMatrix[2, 1] == null)
            {
                if (PlayerTurn)
                {
                    label8.Text = "X";
                }
                else
                {
                    label8.Text = "O";
                }
                XoMatrix[2, 1] = label8.Text;
                ChangeTurns();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (count < 9 && XoMatrix[2, 2] == null)
            {
                if (PlayerTurn)
                {
                    label9.Text = "X";
                }
                else
                {
                    label9.Text = "O";
                }
                XoMatrix[2, 2] = label9.Text;
                ChangeTurns();
            }
        }
    }
}
