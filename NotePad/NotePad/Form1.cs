using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace NotePad
{
    public partial class NoteForm : System.Windows.Forms.Form
    {
        private int lastFoundIndex = -1;

        private string title = "Untitled";
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                Text = title; 
            }
        }
        public Color FontColor { get; set; } = Color.Black;

        public NoteForm()
        {
            InitializeComponent();
            Text = "Untitled";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextArea.Font = new Font("Lucida Console", (Height * 3) / 100);
        }

        private void AlertBox()
        {
            DialogResult result = MessageBox.Show("Do You Want To Save?", "Unsaved Changes",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                save();
            }
        }

        private void save()
        {
            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                saveFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*|PDF(*.pdf)|*.pdf";
                saveFile.Title = "Save As";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFile.FileName;
                    Title = fileName;
                    File.WriteAllText(fileName, TextArea.Text);
                }
            }
        }

        //File
        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (TextArea.Text != "")
            {
                AlertBox();
            }
            TextArea.Text = "";
            Title = "Untitled";
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.Title = "Open File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    Title = fileName;
                    TextArea.Text = File.ReadAllText(fileName);
                }
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (TextArea.Text == "") return;
            if (Title.Equals("Untitled"))
            {
                save();
            }
            File.WriteAllText(Title, TextArea.Text);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (TextArea.Text != "")
            {
                AlertBox();
            }
            Application.Exit();
        }

        //Edit
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextArea.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextArea.Redo();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TextArea.Cut();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TextArea.Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TextArea.Paste();
        }

        //Tools
        private void Font_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            TextArea.Font = fontDialog.Font;
        }

        private void WordWrap_Click(object sender, EventArgs e)
        {
            TextArea.WordWrap = !TextArea.WordWrap;
            WordWrap.Checked = !WordWrap.Checked;
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            TextArea.ForeColor = color.Color;
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextArea.ZoomFactor += 0.1f;
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextArea.ZoomFactor -= 0.1f;
        }

        //Help
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindPanel.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string searchText = SearchTextBox.Text;

            if (!string.IsNullOrEmpty(searchText))
            {
                lastFoundIndex = TextArea.Text.IndexOf(searchText, StringComparison.OrdinalIgnoreCase);

                if (lastFoundIndex != -1)
                {
                    TextArea.Select(lastFoundIndex, searchText.Length);
                    TextArea.Focus();
                }
                else
                {
                    MessageBox.Show("Word not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            FindPanel.Hide();
        }

        private void FindNext_Click(object sender, EventArgs e)
        {
            if (lastFoundIndex != -1)
            {
                string searchText = SearchTextBox.Text.Trim();
                lastFoundIndex = TextArea.Text.IndexOf(searchText, lastFoundIndex + 1, StringComparison.OrdinalIgnoreCase);

                if (lastFoundIndex != -1)
                {
                    TextArea.Select(lastFoundIndex, searchText.Length);
                    TextArea.Focus();
                }
                else
                {
                    MessageBox.Show("No more occurrences found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                search_Click(sender, e);
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            //print.Document = new PrintDocument();
            if (print.ShowDialog() == DialogResult.OK)
            {
                print.Document.PrintPage += DocumentWriter;
                print.Document.Print();
            }
        }

        private void DocumentWriter(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(TextArea.Text, TextArea.Font, new SolidBrush(TextArea.ForeColor), 0, 0);
        }
    }
}
