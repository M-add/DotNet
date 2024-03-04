using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Game
{
    public partial class Form2 : Form
    {
        private int index;
        private DataTable data = new DataTable();
        private Random rand = new Random();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //DataGridViewImageColumn imageCol = new DataGridViewImageColumn
            //{
            //    ImageLayout = DataGridViewImageCellLayout.Stretch,
            //    HeaderText = "Image"
            //};
            //DataGridViewTextBoxColumn text = new DataGridViewTextBoxColumn
            //{
            //    HeaderText = "Text"
            //};
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView1.RowTemplate.Height = 200;
            //dataGridView1.Columns.Add(text);
            //dataGridView1.Columns.Add(imageCol);
            //Image img = Properties.Resources.knight;
            //dataGridView1.Rows.Add("Knight", img);

            data.Columns.Add("Name", typeof(string));
            data.Columns.Add("Id", typeof(int));
            data.Columns.Add("Dept", typeof(string));
            data.Columns.Add("Mark", typeof(string));

            for (int i = 0; i < 5; i++)
            {
                data.Rows.Add("Name-" + (i + 1), 1 + i, "AI", rand.Next(80, 100));
            }
            dataGridView1.DataSource = data;



            dataGridView1.CurrentCell = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            richTextBox1.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            richTextBox2.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            richTextBox3.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            richTextBox4.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //pictureBox1.Image = dataGridView1.Rows[index].Cells[1].Value as Image;
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            DataGridViewRow selected = dataGridView1.Rows[index];
            selected.Cells[0].Value = richTextBox1.Text;
            selected.Cells[1].Value = richTextBox2.Text;
            selected.Cells[2].Value = richTextBox3.Text;
            selected.Cells[3].Value = richTextBox4.Text;
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int current = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(current);
            }
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "" && richTextBox2.Text != "" &&
                richTextBox3.Text != "" && richTextBox4.Text != "")
            {
                data.Rows.Add(richTextBox1.Text, richTextBox2.Text, richTextBox3.Text, richTextBox4.Text);
                richTextBox1.Text = richTextBox2.Text = richTextBox3.Text = richTextBox4.Text = "";
            }
            else
            {
                string Name = Interaction.InputBox("Enter the Name:-", "Data", "", -1, -1);
                int Id = int.Parse(Interaction.InputBox("Enter the Id:-", "Data", "", -1, -1));
                string Dept = Interaction.InputBox("Enter the Dept:-", "Data", "", -1, -1);
                int Mark = int.Parse(Interaction.InputBox("Enter the Mark:-", "Data", "", -1, -1));

                data.Rows.Add(Name, Id, Dept, Mark);
            }

            dataGridView1.ClearSelection();
            int lastRowIndex = dataGridView1.Rows.Count - 1;
            if (lastRowIndex >= 0)
            {
                dataGridView1.Rows[lastRowIndex].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[lastRowIndex].Cells[0];
            }
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
            }
            MessageBox.Show("The Total Mark is " + sum.ToString());
        }
    }
}
