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
    public partial class ColorPicker : Form
    {
        List<Color> Colors = new List<Color>();

        public ColorPicker()
        {
            InitializeComponent();
            KeyPreview = true;
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Position;
            timer.Start();
        }

        private void Position(object sender, EventArgs e)
        {
            Point cursorPosition = Cursor.Position;
            Color pickedColor = GetPixelColor(cursorPosition);
            FillPanel.BackColor = pickedColor;
        }

        private void ColorPicker_Load(object sender, EventArgs e)
        {
            RedSlider.DataBindings.Add("SliderValue", RedValue, "Text");
            BlueSlider.DataBindings.Add("SliderValue", BlueValue, "Text");
            GreenSlider.DataBindings.Add("SliderValue", GreenValue, "Text");
        }

        private void ColorPickerKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.X)
            {
                Point cursorPosition = Cursor.Position;
                Color pickedColor = GetPixelColor(cursorPosition);
                FillPanel.BackColor = pickedColor;

                Colors.Add(pickedColor);
                StoreColor(Colors[Colors.Count - 1]);
            }
        }

        private void StoreColor(Color color)
        {
            Label label = new Label
            {
                Dock = DockStyle.Top,
                BackColor = color,
                Text = Text = $"{color.R}, {color.G}, {color.B}",
                Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular),
                BorderStyle = BorderStyle.None
            };
            if ((color.R + color.B + color.G) / 3 <= 128)
            {
                label.ForeColor = Color.White;
            }

            label.MouseClick += LabelMouseClick;
            label.MouseDown += LabelMouseDown;
            label.MouseUp += LabelMouseUp;

            ColorValuePanel.Controls.Add(label);
        }

        private Color DefaultColor;

        private void LabelMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label CurrentLabel = sender as Label;
                Clipboard.SetText(CurrentLabel.Text);

                AdjustPanel.BackColor = DefaultColor;
                CustomColorSetUp(DefaultColor);
            }
        }
        private void LabelMouseDown(object sender, MouseEventArgs e)
        {
            Label current = sender as Label;
            DefaultColor = current.BackColor;
            current.BackColor = SystemColors.ButtonHighlight;
        }
        private void LabelMouseUp(object sender, MouseEventArgs e)
        {
            Label current = sender as Label;
            current.BackColor = DefaultColor;
        }

        private Color GetPixelColor(Point location)
        {
            Bitmap screen = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                           Screen.PrimaryScreen.Bounds.Height);

            Graphics graphics = Graphics.FromImage(screen);
            graphics.CopyFromScreen(location, location, new Size(1, 1), CopyPixelOperation.SourceCopy);

            return screen.GetPixel(location.X, location.Y);
        }

        private void CustomColorSetUp(Color customColor)
        {
            RedValue.Text = customColor.R.ToString();
            BlueValue.Text = customColor.B.ToString();
            GreenValue.Text = customColor.G.ToString();
        }

        private void CustomColor()
        {
            int R = (int)RedSlider.SliderValue;
            int G = (int)GreenSlider.SliderValue;
            int B = (int)BlueSlider.SliderValue;

            AdjustPanel.BackColor = Color.FromArgb(R, G, B);
        }
        private void RedSlider_ValueChanged(object sender, float e)
        {
            int value = (int)RedSlider.SliderValue;
            RedValue.Text = value.ToString();
            CustomColor();
        }

        private void GreenSlider_ValueChanged(object sender, float e)
        {
            int value = (int)GreenSlider.SliderValue;
            GreenValue.Text = value.ToString();
            CustomColor();
        }

        private void BlueSlider_ValueChanged(object sender, float e)
        {
            int value = (int)BlueSlider.SliderValue;
            BlueValue.Text = value.ToString();
            CustomColor();
        }

        private void CustomColorValue_Click(object sender, EventArgs e)
        {
            Color custom = AdjustPanel.BackColor;
            string value = $"{custom.R} ,{custom.G} , {custom.B}";
            Clipboard.SetText(value);
        }
    }
}
