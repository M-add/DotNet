using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static userControl.SlideBar;
using System.Windows;

namespace userControl
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public void UpdateValue(float value)
        {
            spinBox.Text = ((int)value).ToString();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            spinBox.Text = "0";
        }

        public event EventHandler<float> UpButtonClicked;
        public event EventHandler<float> DownButtonClicked;

        protected virtual void OnUpButtonClicked(float value)
        {
            UpButtonClicked?.Invoke(this, value);
        }
        protected virtual void OnDownButtonClicked(float value)
        {
            DownButtonClicked?.Invoke(this, value);
        }

        private void up_Click_1(object sender, EventArgs e)
        {
            int value = int.Parse(spinBox.Text);
            value++;
            if (value > 100) return;
            spinBox.Text = value.ToString();

            OnUpButtonClicked(float.Parse(spinBox.Text));
        }

        private void down_Click(object sender, EventArgs e)
        {
            int value = int.Parse(spinBox.Text);

            if (value == 0) return;
            value--;
            spinBox.Text = value.ToString();

            OnDownButtonClicked(float.Parse(spinBox.Text));
        }

        private void UserControl1_Resize(object sender, EventArgs e)
        {
            int Fontheight = spinBox.Height / 2;
            spinBox.Font = new Font("Times New Roman", Fontheight);
        }

        private bool MouseDownOnUpClick = false;
        Timer upTimer;

        private void up_MouseDown(object sender, MouseEventArgs e)
        {
            if (upTimer == null)
            {
                upTimer = new Timer();
                upTimer.Interval = 180;
                upTimer.Tick += UpTimerTick;
            }
            upTimer.Start(); 
        }

        private void UpTimerTick(object sender, EventArgs e)
        {
            int value = int.Parse(spinBox.Text);
            value++;
            if (value > 100)
            {
                upTimer.Stop();
                MouseDownOnUpClick = false;
                return;
            }
            spinBox.Text = value.ToString();
            OnUpButtonClicked(float.Parse(spinBox.Text));
        }

        private void up_MouseUp(object sender, MouseEventArgs e)
        {
            if (upTimer != null)
            {
                upTimer.Stop();
                MouseDownOnUpClick = false;
            }
        }

        bool MouseDownOnDownClick = false;
        Timer downTimer;

        private void down_MouseDown(object sender, MouseEventArgs e)
        {
            if(downTimer == null)
            {
                downTimer = new Timer();
                downTimer.Interval = 170;
                downTimer.Tick += DownTimerTick;
            }
            downTimer.Start();
        }

        private void DownTimerTick(object sender, EventArgs e)
        {
            int value = int.Parse(spinBox.Text);
            if (value == 0)
            {
                downTimer.Stop();
                MouseDownOnDownClick = false;
                return;
            }
            value--;
            spinBox.Text = value.ToString();
            OnDownButtonClicked(float.Parse(spinBox.Text));
        }

        private void down_MouseUp(object sender, MouseEventArgs e)
        {
            if(downTimer != null)
            {
                downTimer.Stop();
                MouseDownOnDownClick = false;
            }
        }


        //private void ResizeControl(Rectangle Component, Control control)
        //{
        //    float xAxis = (float)(Width) / (float)(originalSize.Width);
        //    float yAxis = (float)(Height) / (float)(originalSize.Height);

        //    int newXPosition = (int)(Component.X * xAxis);
        //    int newYPosition = (int)(Component.Y * yAxis);

        //    int newWidth = (int)(Component.Width * xAxis);
        //    int newHeight = (int)(Component.Height * yAxis);

        //    control.Location = new Point(newXPosition, newYPosition);
        //    control.Size = new Size(newWidth, newHeight);
        //}


    }
}
