using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_MAnager
{
    public partial class Scale : UserControl
    {
        public int WidthChange { get; set; }
        public int HeightChange { get; set; }
        private Color submitButtonColor = Color.WhiteSmoke;
        public Color SubmitButtonColor
        {
            get { return submitButtonColor; }
            set
            {
                submitButtonColor = value;
                ColorChange();
            }
        }

        public event EventHandler SubmitClick;

        public Scale()
        {
            InitializeComponent();
            ColorChange();
        }

        private void ColorChange()
        {
            SizeSubmitButton.BackColor = SubmitButtonColor;
        }
        private void SizeSubmitButtonClick(object sender, EventArgs e)
        {
            if (WidthBox.Text !="" && HeightBox.Text != "")
            {
                WidthChange = int.Parse(WidthBox.Text);
                HeightChange = int.Parse(HeightBox.Text);

                SubmitClick.Invoke(this, EventArgs.Empty); 
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            panel1.Height = panel2.Height = (Height / 4) * 3;
            SizeSubmitButton.Height = (Height / 4);
            panel2.Width = panel1.Width = Width / 2;
            WidthLabel.Height = HeightLabel.Height = (panel1.Height / 4) * 2;
            panel1.BorderStyle =panel2.BorderStyle= BorderStyle.Fixed3D;
        }
    }
}
