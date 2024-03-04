using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using userControl;

namespace userControl
{
    public partial class SlideBar : UserControl
    {
        public event EventHandler<float> ValueChanged;

        public SlideBar()
        {
            InitializeComponent();
            Slider.Height = 30;
        }

        protected virtual void OnValueChanged(float value)
        {
            ValueChanged?.Invoke(this, value);
        }

        //public class ValueChangedEventArgs : EventArgs
        //{
        //    public float Value { get; }

        //    public ValueChangedEventArgs(float value)
        //    {
        //        Value = value;
        //    }
        //}

        public void UpdateValueFromExternal(float value)
        {
            DefaultValue = value;
            Slider.Refresh();
        }

        float DefaultValue = 0.1f, Min = 0.0f , Max = 100.0f;

        private void Slider_Click(object sender, EventArgs e)
        {

        }

        public float Bar(float value)
        {
            return (Slider.Width - 24) * (value - Min) / (float)(Max - Min);
        }
        private UserControl1 obj = new UserControl1();

        //To adjust thumb value
        public void Thumb(float value)
        {
            if (value < Min) value = Min;
            if (value > Max) value = Max;
            DefaultValue = value;
            Slider.Refresh();

            OnValueChanged(DefaultValue);
        }

        //To convert and return slider co-ordinate value
        public float SliderWidth(int x)
        {
            return Min + (Max - Min) * x / (float)Slider.Width;
        }

        private void Slider_Paint(object sender, PaintEventArgs e)
        {
            float BarSize = 0.45f;
            float x = Bar(DefaultValue);
            int y = (int)(Slider.Height * BarSize);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(Brushes.DimGray, 0, y, Slider.Width, y / 2);
            e.Graphics.FillRectangle(Brushes.Red, 0, y , x, y/2);

            using (Pen pen = new Pen(Color.Black, 10))
            {
                e.Graphics.DrawEllipse(pen, x + 4, y - 6, Slider.Height / 2, Slider.Height / 2);
                e.Graphics.FillEllipse(Brushes.Red, x + 4, y - 6, Slider.Height / 2, Slider.Height / 2);
            }
            using (Pen pen = new Pen(Color.White, 8))
            {
                e.Graphics.DrawEllipse(pen, x + 4, y - 6, Slider.Height / 2, Slider.Height / 2);
            }
        }

        bool mouse = false;

        private void Slider_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void SlideBar_Resize(object sender, EventArgs e)
        {
        } 

        private void Slider_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            Thumb(SliderWidth(e.X));
        }

        private void Slider_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouse) return;

            Thumb(SliderWidth(e.X));
        }

        
    }
}
