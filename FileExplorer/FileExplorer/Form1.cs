using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeTreeView();
            InitializeListView();
        }

        private void InitializeTreeView()
        {
            // Add drives to the tree view
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                TreeNode node = new TreeNode(drive.Name);
                node.Tag = drive.RootDirectory.FullName;
                node.Nodes.Add(""); // Add a dummy node to enable lazy loading
                treeView.Nodes.Add(node);
            }

            // Add special folders
            var specialFolders = Enum.GetValues(typeof(Environment.SpecialFolder))
                                     .Cast<Environment.SpecialFolder>()
                                     .Where(folder => folder != Environment.SpecialFolder.MyComputer && folder != Environment.SpecialFolder.PrinterShortcuts)
                                     .ToList();

            foreach (var folder in specialFolders)
            {
                string folderPath = Environment.GetFolderPath(folder);
                TreeNode node = new TreeNode(folder.ToString());
                node.Tag = folderPath;
                node.Nodes.Add(""); // Add a dummy node to enable lazy loading
                treeView.Nodes.Add(node);
            }
        }


        private void InitializeListView()
        {
            listView.View = View.Details;
            listView.Columns.Add("Name", 200);
            listView.Columns.Add("Type", 100);
            listView.Columns.Add("Size", 100);
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode currentNode = e.Node;
            if (currentNode.Nodes.Count == 1 && currentNode.Nodes[0].Text == "")
            {
                currentNode.Nodes.Clear();
                string[] directories;
                try
                {
                    directories = Directory.GetDirectories(currentNode.Tag.ToString());
                    foreach (string directory in directories)
                    {
                        DirectoryInfo dir = new DirectoryInfo(directory);
                        TreeNode node = new TreeNode(dir.Name);
                        node.Tag = dir.FullName;
                        node.Nodes.Add(""); // Add a dummy node to enable lazy loading
                        currentNode.Nodes.Add(node);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Access denied.");
                }
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            PopulateListView(e.Node.Tag.ToString());
        }

        private void PopulateListView(string directoryPath)
        {
            listView.Items.Clear();
            try
            {
                string[] directories = Directory.GetDirectories(directoryPath);
                foreach (string directory in directories)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(directory);
                    ListViewItem item = new ListViewItem(dirInfo.Name);
                    item.SubItems.Add("Directory");
                    item.SubItems.Add(""); // No size for directories
                    item.Tag = directory; // Store directory path in Tag property
                    item.ImageIndex = 0; // Optional: Set directory icon
                    listView.Items.Add(item);
                }

                string[] files = Directory.GetFiles(directoryPath);
                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    ListViewItem item = new ListViewItem(fileInfo.Name);
                    item.SubItems.Add(fileInfo.Extension);
                    item.SubItems.Add(fileInfo.Length.ToString());
                    item.Tag = file; // Store file path in Tag property
                    item.ImageIndex = 1; // Optional: Set file icon
                    listView.Items.Add(item);
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access denied.");
            }
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                string selectedFilePath = Path.Combine(treeView.SelectedNode.Tag.ToString(), listView.SelectedItems[0].Text);
                if (File.Exists(selectedFilePath))
                {
                    using (TextEditorForm textEditorForm = new TextEditorForm(selectedFilePath))
                    {
                        textEditorForm.ShowDialog();
                    }
                }
            }
        }
    }
}
