using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegionManager
{
    public partial class IdManager : Form
    {
        public int IdValue { get; set; }

        public IdManager()
        {
            InitializeComponent();
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            ErrorPoint:
            if (IdTextBox.Text != "")
            {
                try
                {
                    IdValue = int.Parse(IdTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Enter a valid Input !!");
                    goto ErrorPoint;
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
