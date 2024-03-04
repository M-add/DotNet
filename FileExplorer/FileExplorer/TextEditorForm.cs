using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileExplorer
{
    public class TextEditorForm : Form
    {
        private TextBox textBox;

        public TextEditorForm(string filePath)
        {
            InitializeComponents();
            LoadFile(filePath);
        }

        private void InitializeComponents()
        {
            textBox = new TextBox();
            textBox.Dock = DockStyle.Fill;
            textBox.Multiline = true;
            textBox.ReadOnly = true;
            Controls.Add(textBox);
            Text = "Text Editor";
            Size = new System.Drawing.Size(400, 300);
        }

        private void LoadFile(string filePath)
        {
            try
            {
                string text = File.ReadAllText(filePath);
                textBox.Text = text;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
