namespace userControl
{
    partial class SlideBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Slider = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Slider
            // 
            this.Slider.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Slider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Slider.Location = new System.Drawing.Point(0, 0);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(500, 40);
            this.Slider.TabIndex = 0;
            this.Slider.TabStop = false;
            this.Slider.Click += new System.EventHandler(this.Slider_Click);
            this.Slider.Paint += new System.Windows.Forms.PaintEventHandler(this.Slider_Paint);
            this.Slider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Slider_MouseDown);
            this.Slider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Slider_MouseMove);
            this.Slider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Slider_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Slider);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 40);
            this.panel1.TabIndex = 1;
            // 
            // SlideBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "SlideBar";
            this.Size = new System.Drawing.Size(500, 40);
            this.Resize += new System.EventHandler(this.SlideBar_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Slider;
        private System.Windows.Forms.Panel panel1;
    }
}
