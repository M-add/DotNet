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
    public partial class DropBox : UserControl
    {
        Panel dropdownPanel;
        ListBox listBox;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BindingList<string> Items { get; set; } = new BindingList<string>();

        //[Browsable(true)]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool Visibility
        {
            get { return dropdownPanel.Visible; }
            set { dropdownPanel.Visible = value; }
        }

        private Font listBoxFont = new Font("Arial", 10, FontStyle.Bold);
        public Font ListBoxFont
        {
            get { return listBoxFont; }
            set
            {
                listBoxFont = value;
                listBox.Font = value;
            }
        }
        private Color listBoxFontColor = SystemColors.ControlText;
        public Color ListBoxFontColor
        {
            get { return listBoxFontColor; }
            set
            {
                listBoxFontColor = value;
                listBox.ForeColor = value;
            }
        }
        private Color listBoxBackColor;
        public Color ListBoxBackColor
        {
            get { return listBoxBackColor; }
            set
            {
                listBoxBackColor = value;
                listBox.BackColor = value;
            }
        }
        private Font textBoxFont = new Font("Arial", 10, FontStyle.Bold);
        public Font TextBoxFont
        {
            get { return textBoxFont; }
            set
            {
                textBoxFont = value;
                textArea.Font = value;
            }
        }
        private Color textBoxFontColor = SystemColors.ControlText;
        public Color TextBoxFontColor
        {
            get { return textBoxFontColor; }
            set
            {
                textBoxFontColor = value;
                textArea.ForeColor = value;
            }
        }
        private Color textBoxBackColor;
        public Color TextBoxBackColor
        {
            get { return textBoxBackColor; }
            set
            {
                textBoxBackColor = value;
                textArea.BackColor = value;
            }
        }

        private Color dropButtonColor = Color.Gray;
        public Color DropButtonColor
        {
            get { return dropButtonColor; }
            set
            {
                dropButtonColor = value;
                Down.BackColor = value;
            }
        }
        //public event EventHandler SelectedItemChanged;

        public DropBox()
        {
            InitializeComponent();

            InitializeDropdownPanel();

            textArea.Font = TextBoxFont;
            textArea.ForeColor = TextBoxFontColor;
            textArea.BackColor = TextBoxBackColor;

            Down.BackColor = DropButtonColor;
        }

        private void InitializeDropdownPanel()
        {
            dropdownPanel = new Panel();
            dropdownPanel.BorderStyle = BorderStyle.Fixed3D;
            dropdownPanel.Visible = Visibility;
            dropdownPanel.Location = new Point(mainDropPanel.Location.X, mainDropPanel.Height);
            dropdownPanel.Size = new Size(Width, Height - mainDropPanel.Height);
            dropdownPanel.AutoScroll = true;

            listBox = new ListBox();
            listBox.Dock = DockStyle.Fill;

            listBox.DataSource = Items;
            listBox.Font = ListBoxFont;
            listBox.ForeColor = ListBoxFontColor;
            listBox.BackColor = ListBoxBackColor;

            listBox.SelectedIndexChanged += ListBoxSelectedIndexChanged;

            dropdownPanel.Controls.Add(listBox);
            Controls.Add(dropdownPanel);
        }

        private void ListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if(!Visibility)
            {
                textArea.Text = string.Empty;
            }
            else if (listBox.SelectedIndex != -1)
            {
                textArea.Text = listBox.SelectedItem.ToString();
                dropdownPanel.Visible = false;

                //SelectedItemChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void DownClick(object sender, EventArgs e)
        {
            dropdownPanel.Visible = !dropdownPanel.Visible;

            //listBox.Items.Clear();      
        }
    }
}
