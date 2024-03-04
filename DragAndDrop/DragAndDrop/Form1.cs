using System;
using System.Drawing;
using System.Windows.Forms;
using Transitions;

namespace DragAndDrop
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;
        private Point offset;
        private Random random = new Random();
        private object clicked;

        public Form1()
        {
            InitializeComponent();
            //DragPanel.MouseDown += DragPanelMouseDown;
            //DragPanel.MouseUp += DragPanelMouseUp;
            //DragPanel.MouseMove += DragPanelMouseMove;
            toggle.MouseClick += ToggleMouseClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void DragPanelMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                offset = new Point(e.X, e.Y);
            }
        }

        private void DragPanelMouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void DragPanelMouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Control Object = sender as Control;
                Point newLocation = Object.Location;

                newLocation.X += e.X - offset.X;
                newLocation.Y += e.Y - offset.Y;

                newLocation.X = Math.Max(0, Math.Min(newLocation.X, WorkingArea.ClientSize.Width - Object.Width));
                newLocation.Y = Math.Max(0, Math.Min(newLocation.Y, WorkingArea.ClientSize.Height - Object.Height));

                Object.Location = newLocation;
            }
        }

        private void DragPanelClick(object sender, EventArgs e)
        {
            clicked = DragPanel;
        }

        private void ToggleMouseClick(object sender, MouseEventArgs e)
        {
            clicked = toggle;
        }

        private void luffyClick(object sender, EventArgs e)
        {
            clicked = luffy;
        }
        private void WorkingAreaMouseClick(object sender, MouseEventArgs e)
        {
            if (clicked is Panel)
            {
                Panel panel = new Panel();
                panel.Size = DragPanel.Size;
                panel.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                panel.Location = e.Location;
                panel.BringToFront();

                panel.MouseDown += DragPanelMouseDown;
                panel.MouseUp += DragPanelMouseUp;
                panel.MouseMove += DragPanelMouseMove;

                WorkingArea.Controls.Add(panel);
            }
            else if (clicked is UserControl)
            {
                ToggleButton tog = new ToggleButton();
                tog.Size = toggle.Size;
                tog.Location = e.Location;
                tog.BringToFront();

                tog.MouseDown += DragPanelMouseDown;
                tog.MouseUp += DragPanelMouseUp;
                tog.MouseMove += DragPanelMouseMove;

                WorkingArea.Controls.Add(tog);
            }
            else if (clicked is PictureBox)
            {
                PictureBox pic = new PictureBox();
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Image = Properties.Resources.Gear5;
                pic.Size = luffy.Size;
                pic.Location = e.Location;
                pic.BringToFront();

                pic.MouseDown += DragPanelMouseDown;
                pic.MouseUp += DragPanelMouseUp;
                pic.MouseMove += DragPanelMouseMove;

                WorkingArea.Controls.Add(pic);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            
        }
    }
}
