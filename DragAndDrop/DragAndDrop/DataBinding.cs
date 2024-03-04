using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDrop
{
    public partial class DataBinding : Form
    {
        public DataBinding()
        {
            InitializeComponent();
        }

        private void DataBinding_Load(object sender, EventArgs e)
        {
            SplitContainer splitContainer = new SplitContainer
            {
                Dock = DockStyle.Fill,
                Orientation = Orientation.Horizontal,
            };

            // Create controls for Panel1
            TextBox textBox1 = new TextBox
            {
                Multiline = true,
                Dock = DockStyle.Fill,
                BackColor = Color.SteelBlue
            };

            // Create controls for Panel2
            TextBox textBox2 = new TextBox
            {
                Multiline = true,
                Dock = DockStyle.Fill,
                BackColor = Color.Tan
            };

            // Add controls to panels
            splitContainer.Panel1.Controls.Add(textBox1);
            splitContainer.Panel2.Controls.Add(textBox2);

            // Add the SplitContainer to the form
            Controls.Add(splitContainer);
        }

        private void DataBinding_Resize(object sender, EventArgs e)
        {

        }
    }
}
