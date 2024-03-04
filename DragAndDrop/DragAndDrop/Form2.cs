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
    public partial class Form2 : Form
    {
        private int currentRadius = 0;
        private int maxRadius = 100;
        private Timer timer = new Timer();

        public Form2()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.ClientSize = new Size(400, 400);

            timer.Interval = 20; // Set the interval for smooth animation
            timer.Tick += TimerTick;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            currentRadius += 2; // Increase the radius for a smoother expansion

            if (currentRadius >= maxRadius)
            {
                timer.Stop();
                currentRadius = 0; // Reset radius for the next click
            }

            this.Invalidate(); // Redraw the form to show the updated circle
        }
        Point clickPoint;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DoubleBuffered = true;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            e.Graphics.FillEllipse(Brushes.Blue, clickPoint.X - currentRadius,
                clickPoint.Y - currentRadius, 2 * currentRadius, 2 * currentRadius);
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            clickPoint = new Point(e.X, e.Y);
            currentRadius = 0; // Reset the radius for a new click
            timer.Start();
        }
    }
}
