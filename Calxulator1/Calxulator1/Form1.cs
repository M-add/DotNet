using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calxulator1
{
    public partial class Form1 : Form
    {
        //private Rectangle buttonOne;
        //private Rectangle buttonTwo;
        //private Rectangle buttonThree;
        //private Rectangle buttonFour;
        //private Rectangle buttonFive;
        //private Rectangle buttonSix;
        //private Rectangle buttonSeven;
        //private Rectangle buttonEight;
        //private Rectangle buttonNine;
        //private Rectangle buttonTen;
        //private Rectangle buttonEleven;
        //private Rectangle buttonTwelve;
        //private Rectangle buttonThirteen;
        //private Rectangle buttonFourteen;
        //private Rectangle buttonFifteen;
        //private Rectangle buttonSixteen;
        //private Rectangle buttonSeventeen;
        //private Rectangle buttonEighteen;
        //private Rectangle buttonNineteen;

        //private Size originalSize;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //originalSize = this.Size;
            //buttonOne = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            //buttonTwo = new Rectangle(button2.Location.X, button2.Location.Y, button2.Width, button2.Height);
            //buttonThree = new Rectangle(button3.Location.X, button3.Location.Y, button3.Width, button3.Height);
            //buttonFour = new Rectangle(button4.Location.X, button4.Location.Y, button4.Width, button4.Height);
            //buttonFive = new Rectangle(button5.Location.X, button5.Location.Y, button5.Width, button5.Height);
            //buttonSix = new Rectangle(button6.Location.X, button6.Location.Y, button6.Width, button6.Height);
            //buttonSeven = new Rectangle(button7.Location.X, button7.Location.Y, button7.Width, button7.Height);
            //buttonEight = new Rectangle(button8.Location.X, button8.Location.Y, button8.Width, button8.Height);
            //buttonNine = new Rectangle(button9.Location.X, button9.Location.Y, button9.Width, button9.Height);
            //buttonTen = new Rectangle(button10.Location.X, button10.Location.Y, button10.Width, button10.Height);
            //buttonEleven = new Rectangle(button11.Location.X, button11.Location.Y, button11.Width, button11.Height);
            //buttonTwelve = new Rectangle(button12.Location.X, button12.Location.Y, button12.Width, button12.Height);
            //buttonThirteen = new Rectangle(button13.Location.X, button13.Location.Y, button13.Width, button13.Height);
            //buttonFourteen = new Rectangle(button14.Location.X, button14.Location.Y, button14.Width, button14.Height);
            //buttonFifteen = new Rectangle(button15.Location.X, button15.Location.Y, button15.Width, button15.Height);
            //buttonSixteen = new Rectangle(button16.Location.X, button16.Location.Y, button16.Width, button16.Height);
            //buttonSeventeen = new Rectangle(button17.Location.X, button17.Location.Y, button17.Width, button17.Height);
            //buttonEighteen = new Rectangle(button18.Location.X, button18.Location.Y, button18.Width, button18.Height);
            //buttonNineteen = new Rectangle(button19.Location.X, button19.Location.Y, button19.Width, button19.Height);



        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int height = panel1.Height / 7;
            panel2.Height = panel3.Height = panel4.Height = panel5.Height = panel6.Height = panel7.Height = height;
            richTextBox1.Height = height;

            int width = panel2.Width / 4;
            button1.Width = button2.Width = button3.Width = button4.Width = width;
            button5.Width = button6.Width = button7.Width = button8.Width = width;
            button9.Width = button10.Width = button11.Width = button12.Width = width;
            button13.Width = button14.Width = button15.Width = button16.Width = width;
            button17.Width = button18.Width = button19.Width = richTextBox1.Width = width;
            button20.Width = button22.Width = button23.Width = width;

            //resizeControl(buttonOne, button1);
            //resizeControl(buttonTwo, button2);
            //resizeControl(buttonThree, button3);
            //resizeControl(buttonFour, button4);
            //resizeControl(buttonFive, button5);
            //resizeControl(buttonSix, button6);
            //resizeControl(buttonSeven, button7);
            //resizeControl(buttonEight, button8);
            //resizeControl(buttonNine, button9);
            //resizeControl(buttonTen, button10);
            //resizeControl(buttonEleven, button11);
            //resizeControl(buttonTwelve, button12);
            //resizeControl(buttonThirteen, button13);
            //resizeControl(buttonFourteen, button14);
            //resizeControl(buttonFifteen, button15);
            //resizeControl(buttonSixteen, button16);
            //resizeControl(buttonSeventeen, button17);
            //resizeControl(buttonEighteen, button18);
            //resizeControl(buttonNineteen, button19);

        }

        //private void resizeControl(Rectangle button, Control control)
        //{
        //    float xAxis = (float)(this.Width) / (float)(originalSize.Width);
        //    float yAxis = (float)(this.Height) / (float)(originalSize.Height);

        //    int newXPosition = (int)(button.X * xAxis);
        //    int newYPosition = (int)(button.Y * yAxis);

        //    int newWidth = (int)(button.Width * xAxis);
        //    int newHeight = (int)(button.Height * yAxis);

        //    control.Location = new Point(newXPosition, newYPosition);
        //    control.Size = new Size(newWidth, newHeight);
        //}


        private bool FirstTyping = true;
         
        private void button1_Click(object sender, EventArgs e)
        {
            // Clear
            richTextBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Backspace
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 7
            AppendToExpression("7");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 8
            AppendToExpression("8");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 9
            AppendToExpression("9");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // 4
            AppendToExpression("4");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // 5
            AppendToExpression("5");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // 6
            AppendToExpression("6");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // 1
            AppendToExpression("1");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // 2
            AppendToExpression("2");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // 3
            AppendToExpression("3");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // Zero
            AppendToExpression("0");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Divide
            AppendToExpression("/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Modulo
            AppendToExpression("%");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Multiply
            AppendToExpression("*");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Addition
            AppendToExpression("+");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Subtract
            AppendToExpression("-");
        }
        
        private void button18_Click(object sender, EventArgs e)
        {
            // Decimal
            AppendToExpression(".");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // Equal To
            CalculateResult();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //Open paranthesis
            AppendToExpression("(");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //Close paranthesis
            AppendToExpression(")");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            // Square root
            if (double.TryParse(richTextBox1.Text, out double input))
            {
                double result = Math.Sqrt(input);
                richTextBox1.Text = result.ToString();
            }
            else
            {
                richTextBox1.Text = "Invalid Input";
            }
        }

        private void AppendToExpression(string value)
        {
            if (FirstTyping)
            {
                richTextBox1.Clear();
                FirstTyping = false;
            }
            if (richTextBox1.Text.Length > 0)
            {
                char lastChar = richTextBox1.Text[richTextBox1.Text.Length - 1];
                if (Check(lastChar) && Check(value[0]))
                {
                    richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1) + value;
                    return;
                }
            }

            richTextBox1.Text += value;
        }

        private bool Check(char c)
        {
            char[] symbols = { '+', '-', '*', '/', '%' };

            return Array.IndexOf(symbols, c) != -1;
        }


        private void CalculateResult()
        {
            try
            {
                DataTable dataTable = new DataTable();
                var result = dataTable.Compute(richTextBox1.Text, "");
                richTextBox1.Text = result.ToString();
                //FirstTyping = true;
            }
            catch (Exception ex)
            {
                richTextBox1.Text = "Error";
            }
        }

    }
}
