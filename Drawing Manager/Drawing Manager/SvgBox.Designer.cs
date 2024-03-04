namespace Drawing_MAnager
{
    partial class Svg_Box
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
            this.ImportButton = new System.Windows.Forms.Button();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ImportButton
            // 
            this.ImportButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ImportButton.Location = new System.Drawing.Point(0, 0);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(300, 23);
            this.ImportButton.TabIndex = 0;
            this.ImportButton.Text = "button1";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click_1);
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DrawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawPanel.Location = new System.Drawing.Point(0, 23);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(300, 194);
            this.DrawPanel.TabIndex = 1;
            // 
            // Svg_Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.ImportButton);
            this.Name = "Svg_Box";
            this.Size = new System.Drawing.Size(300, 217);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Panel DrawPanel;
    }
}
