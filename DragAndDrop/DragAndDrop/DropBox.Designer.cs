namespace DragAndDrop
{
    partial class DropBox
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
            this.mainDropPanel = new System.Windows.Forms.Panel();
            this.Down = new System.Windows.Forms.PictureBox();
            this.textArea = new System.Windows.Forms.TextBox();
            this.mainDropPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Down)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDropPanel
            // 
            this.mainDropPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainDropPanel.Controls.Add(this.Down);
            this.mainDropPanel.Controls.Add(this.textArea);
            this.mainDropPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainDropPanel.Location = new System.Drawing.Point(0, 0);
            this.mainDropPanel.Name = "mainDropPanel";
            this.mainDropPanel.Size = new System.Drawing.Size(200, 43);
            this.mainDropPanel.TabIndex = 0;
            // 
            // Down
            // 
            this.Down.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Down.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Down.Dock = System.Windows.Forms.DockStyle.Right;
            this.Down.Image = global::DragAndDrop.Properties.Resources.down;
            this.Down.Location = new System.Drawing.Point(138, 0);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(60, 41);
            this.Down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Down.TabIndex = 1;
            this.Down.TabStop = false;
            this.Down.Click += new System.EventHandler(this.DownClick);
            // 
            // textArea
            // 
            this.textArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textArea.Location = new System.Drawing.Point(0, 0);
            this.textArea.Multiline = true;
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(198, 41);
            this.textArea.TabIndex = 0;
            // 
            // DropBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainDropPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "DropBox";
            this.Size = new System.Drawing.Size(200, 200);
            this.mainDropPanel.ResumeLayout(false);
            this.mainDropPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Down)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainDropPanel;
        private System.Windows.Forms.PictureBox Down;
        private System.Windows.Forms.TextBox textArea;
    }
}
