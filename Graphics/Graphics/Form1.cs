using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.WhiteSmoke;
            themeText.BackColor = Color.Transparent;
        }

        private void theme_CheckedChanged(object sender, EventArgs e)
        {
            if (theme.Checked)
            {
                this.BackColor = Color.DimGray;
                themeText.ForeColor = Color.Snow;
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
                themeText.ForeColor = Color.Black;
            }
        }

        private void toggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (theme.Checked)
            {
                this.BackColor = Color.DimGray;
                themeText.ForeColor = Color.Snow;
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
                themeText.ForeColor = Color.Black;
            }
        }
    }
}
