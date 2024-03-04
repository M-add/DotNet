using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDrop
{
    public partial class DataBind : UserControl
    {
        public DataBind()
        {
            InitializeComponent();
        }

        private void DataBindLoad(object sender, EventArgs e)
        {
            button1.DataBindings.Add("Text", textBox1, "Text");
            button1.DataBindings.Add("Size", textBox1, "Size");
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            textBox1.Width = (Width * 80) / 100;
            textBox1.Height = (Height * 25) / 100;
        }
    }
}
