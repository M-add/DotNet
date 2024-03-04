namespace userControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.spinPanel = new System.Windows.Forms.Panel();
            this.SpinBox = new userControl.UserControl1();
            this.SlidePanel = new System.Windows.Forms.Panel();
            this.slideBar1 = new userControl.SlideBar();
            this.panel1.SuspendLayout();
            this.spinPanel.SuspendLayout();
            this.SlidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.spinPanel);
            this.panel1.Controls.Add(this.SlidePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(377, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 572);
            this.panel1.TabIndex = 0;
            // 
            // spinPanel
            // 
            this.spinPanel.Controls.Add(this.SpinBox);
            this.spinPanel.Location = new System.Drawing.Point(245, 61);
            this.spinPanel.Name = "spinPanel";
            this.spinPanel.Size = new System.Drawing.Size(552, 132);
            this.spinPanel.TabIndex = 3;
            // 
            // SpinBox
            // 
            this.SpinBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpinBox.Location = new System.Drawing.Point(0, 0);
            this.SpinBox.Name = "SpinBox";
            this.SpinBox.Size = new System.Drawing.Size(552, 132);
            this.SpinBox.TabIndex = 0;
            // 
            // SlidePanel
            // 
            this.SlidePanel.Controls.Add(this.slideBar1);
            this.SlidePanel.Location = new System.Drawing.Point(245, 199);
            this.SlidePanel.Name = "SlidePanel";
            this.SlidePanel.Size = new System.Drawing.Size(552, 45);
            this.SlidePanel.TabIndex = 2;
            // 
            // slideBar1
            // 
            this.slideBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slideBar1.Location = new System.Drawing.Point(0, 0);
            this.slideBar1.Name = "slideBar1";
            this.slideBar1.Size = new System.Drawing.Size(552, 45);
            this.slideBar1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 572);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.spinPanel.ResumeLayout(false);
            this.SlidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private SlideBar slideBar1;
        private System.Windows.Forms.Panel SlidePanel;
        private System.Windows.Forms.Panel spinPanel;
        private UserControl1 SpinBox;
    }
}

