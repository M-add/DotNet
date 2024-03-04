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
    public partial class InputDialogForm : Form
    {
        public string Input1 => XText.Text;
        public string Input2 { get; set; } 

        public InputDialogForm()
        {
            InitializeComponent();
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Input2 = YText.Text;
            Close();
        }

        private void InputDialogForm_Load(object sender, EventArgs e)
        {
            YText.Text = Input2;
        }
    }
}

