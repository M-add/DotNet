using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static userControl.SlideBar;
using static userControl.UserControl1;

namespace userControl
{
    public partial class Form1 : Form
    {
        //private UserControl1 obj;

        public Form1()
        {
            InitializeComponent();

            SpinBox.UpButtonClicked  += OnUpClickEvent;
            //SpinBox.UpButtonClicked += OnUpClickEvent1;
            SpinBox.DownButtonClicked += DownClickEvent;

            slideBar1.ValueChanged += SlideBarValueChanged;
        }

        private void SlideBarValueChanged(object sender,float value)
        {
            SpinBox.UpdateValue(value);
        }
        //private void OnUpClickEvent1(object sender, float value)
        //{
        //    MessageBox.Show("1");
        //}
        private void OnUpClickEvent(object sender, float value)
        {
            slideBar1.UpdateValueFromExternal(value);
        }
        public void DownClickEvent(object sender, float value)
        {
            slideBar1.UpdateValueFromExternal(value);
        }
        private Size originalSize;
        private Rectangle SpinBoxOrginalPosition;
        private Rectangle SlideBarORginalSize;

        private void Form1_Load(object sender, EventArgs e)
        {
            originalSize = this.Size;
            SpinBoxOrginalPosition = new Rectangle(spinPanel.Location.X, spinPanel.Location.Y, spinPanel.Width, spinPanel.Height);
            SlideBarORginalSize = new Rectangle(SlidePanel.Location.X, SlidePanel.Location.Y, SlidePanel.Width, SlidePanel.Height);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeControl(SpinBoxOrginalPosition, spinPanel);
            ResizeControl(SlideBarORginalSize, SlidePanel);
            slideBar1.Refresh();
        }

        private void ResizeControl(Rectangle Component, Control control)
        {
            float xAxis = (float)(Width) / (float)(originalSize.Width);
            float yAxis = (float)(Height) / (float)(originalSize.Height);

            int newXPosition = (int)(Component.X * xAxis);
            int newYPosition = (int)(Component.Y * yAxis); 

            int newWidth = (int)(Component.Width * xAxis);
            int newHeight = (int)(Component.Height * yAxis);

            control.Location = new Point(newXPosition, newYPosition);
            control.Size = new Size(newWidth, newHeight);
        }

        private void SpinBox_Load(object sender, EventArgs e)
        {

        }
    }
}
