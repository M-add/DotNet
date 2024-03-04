namespace DragAndDrop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DragPanel = new System.Windows.Forms.Panel();
            this.SideBar = new System.Windows.Forms.Panel();
            this.luffy = new System.Windows.Forms.PictureBox();
            this.WorkingArea = new System.Windows.Forms.Panel();
            this.clock1 = new DragAndDrop.Clock();
            this.circularProgressBar1 = new DragAndDrop.CircularProgressBar();
            this.toggle = new DragAndDrop.ToggleButton();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luffy)).BeginInit();
            this.WorkingArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DragPanel.Location = new System.Drawing.Point(12, 12);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(197, 100);
            this.DragPanel.TabIndex = 0;
            this.DragPanel.Click += new System.EventHandler(this.DragPanelClick);
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.CadetBlue;
            this.SideBar.Controls.Add(this.circularProgressBar1);
            this.SideBar.Controls.Add(this.luffy);
            this.SideBar.Controls.Add(this.toggle);
            this.SideBar.Controls.Add(this.DragPanel);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(241, 685);
            this.SideBar.TabIndex = 1;
            // 
            // luffy
            // 
            this.luffy.Image = global::DragAndDrop.Properties.Resources.Gear5;
            this.luffy.Location = new System.Drawing.Point(12, 250);
            this.luffy.Name = "luffy";
            this.luffy.Size = new System.Drawing.Size(197, 143);
            this.luffy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.luffy.TabIndex = 2;
            this.luffy.TabStop = false;
            this.luffy.Click += new System.EventHandler(this.luffyClick);
            // 
            // WorkingArea
            // 
            this.WorkingArea.BackColor = System.Drawing.SystemColors.ControlLight;
            this.WorkingArea.Controls.Add(this.clock1);
            this.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkingArea.Location = new System.Drawing.Point(241, 0);
            this.WorkingArea.Name = "WorkingArea";
            this.WorkingArea.Size = new System.Drawing.Size(784, 685);
            this.WorkingArea.TabIndex = 2;
            this.WorkingArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WorkingAreaMouseClick);
            // 
            // clock1
            // 
            this.clock1.ClockFontColor = System.Drawing.Color.Black;
            this.clock1.ClockIn = System.Drawing.Color.WhiteSmoke;
            this.clock1.ClockOut = System.Drawing.Color.Black;
            this.clock1.Fonts = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.clock1.HourHandColor = System.Drawing.Color.Black;
            this.clock1.Location = new System.Drawing.Point(121, 149);
            this.clock1.MinuteHandColor = System.Drawing.Color.Black;
            this.clock1.Name = "clock1";
            this.clock1.SecHandcolor = System.Drawing.Color.Black;
            this.clock1.Size = new System.Drawing.Size(367, 327);
            this.clock1.TabIndex = 0;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationInterval = 1;
            this.circularProgressBar1.AnimationSpeed = 100;
            this.circularProgressBar1.BarBackColor = System.Drawing.Color.Black;
            this.circularProgressBar1.BarColor = System.Drawing.Color.Blue;
            this.circularProgressBar1.BarWidth = 20;
            this.circularProgressBar1.InternalColor = System.Drawing.Color.White;
            this.circularProgressBar1.Location = new System.Drawing.Point(33, 470);
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBar1.TabIndex = 3;
            this.circularProgressBar1.Value = 50;
            // 
            // toggle
            // 
            this.toggle.BorderColor = System.Drawing.Color.Black;
            this.toggle.Location = new System.Drawing.Point(12, 149);
            this.toggle.MinimumSize = new System.Drawing.Size(40, 20);
            this.toggle.Name = "toggle";
            this.toggle.OffColor = System.Drawing.Color.Red;
            this.toggle.OnColor = System.Drawing.Color.ForestGreen;
            this.toggle.Size = new System.Drawing.Size(197, 75);
            this.toggle.State = true;
            this.toggle.TabIndex = 1;
            this.toggle.ToggleColor = System.Drawing.Color.White;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 685);
            this.Controls.Add(this.WorkingArea);
            this.Controls.Add(this.SideBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.SideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luffy)).EndInit();
            this.WorkingArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DragPanel;
        private System.Windows.Forms.Panel SideBar;
        private ToggleButton toggle;
        private System.Windows.Forms.Panel WorkingArea;
        private System.Windows.Forms.PictureBox luffy;
        private Clock clock1;
        private CircularProgressBar circularProgressBar1;
    }
}

