using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegionManager;

namespace RegionManager
{
    public partial class TriangelInput : UserControl
    {
        public event EventHandler<List<string>> OnSetButtonClick;

        public TriangelInput()
        {
            InitializeComponent();
        }

        public List<string> SetValues()
        {
            List<string> values = new List<string>
            {
                NameTextBox.Text,
                IdTextBox.Text,
                "3",
                XTextBox.Text,
                YTextBox.Text,
                ParameterTextBox.Text
            };
            return values;
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            List<string> values = SetValues();
            OnSetButtonClick.Invoke(this, values);
        }
    }
}
