namespace DragAndDrop
{
    partial class CustomRadioButton
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
            this.RadioPanel = new System.Windows.Forms.Panel();
            this.TextArea = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // RadioPanel
            // 
            this.RadioPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RadioPanel.Location = new System.Drawing.Point(0, 0);
            this.RadioPanel.Name = "RadioPanel";
            this.RadioPanel.Size = new System.Drawing.Size(66, 49);
            this.RadioPanel.TabIndex = 0;
            this.RadioPanel.Click += new System.EventHandler(this.RadioPanelClick);
            this.RadioPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RadioPanelPaint);
            // 
            // TextArea
            // 
            this.TextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextArea.Location = new System.Drawing.Point(66, 0);
            this.TextArea.Name = "TextArea";
            this.TextArea.Size = new System.Drawing.Size(211, 49);
            this.TextArea.TabIndex = 1;
            this.TextArea.Paint += new System.Windows.Forms.PaintEventHandler(this.TextAreaPaint);
            // 
            // CustomRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextArea);
            this.Controls.Add(this.RadioPanel);
            this.Name = "CustomRadioButton";
            this.Size = new System.Drawing.Size(277, 49);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RadioPanel;
        private System.Windows.Forms.Panel TextArea;
    }
}
