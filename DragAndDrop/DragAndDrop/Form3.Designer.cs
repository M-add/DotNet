namespace DragAndDrop
{
    partial class Form3
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
            this.RectanglePanel = new System.Windows.Forms.Panel();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.submit = new System.Windows.Forms.Button();
            this.AngleBox = new System.Windows.Forms.ComboBox();
            this.SplitCountBox = new System.Windows.Forms.TextBox();
            this.ColorButton = new System.Windows.Forms.Button();
            this.InputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RectanglePanel
            // 
            this.RectanglePanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.RectanglePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RectanglePanel.Location = new System.Drawing.Point(0, 0);
            this.RectanglePanel.Name = "RectanglePanel";
            this.RectanglePanel.Size = new System.Drawing.Size(616, 450);
            this.RectanglePanel.TabIndex = 0;
            this.RectanglePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RectanglePanelPaint);
            this.RectanglePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RectanglePanelMouseClick);
            // 
            // InputPanel
            // 
            this.InputPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InputPanel.Controls.Add(this.submit);
            this.InputPanel.Controls.Add(this.AngleBox);
            this.InputPanel.Controls.Add(this.SplitCountBox);
            this.InputPanel.Controls.Add(this.ColorButton);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputPanel.Location = new System.Drawing.Point(0, 0);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(800, 450);
            this.InputPanel.TabIndex = 1;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.DarkGray;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.submit.Location = new System.Drawing.Point(671, 322);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.SubmitClick);
            // 
            // AngleBox
            // 
            this.AngleBox.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical"});
            this.AngleBox.Location = new System.Drawing.Point(656, 93);
            this.AngleBox.Name = "AngleBox";
            this.AngleBox.Size = new System.Drawing.Size(121, 21);
            this.AngleBox.TabIndex = 1;
            this.AngleBox.SelectedIndexChanged += new System.EventHandler(this.AngleBox_SelectedIndexChanged);
            // 
            // SplitCountBox
            // 
            this.SplitCountBox.Location = new System.Drawing.Point(656, 157);
            this.SplitCountBox.Multiline = true;
            this.SplitCountBox.Name = "SplitCountBox";
            this.SplitCountBox.Size = new System.Drawing.Size(121, 39);
            this.SplitCountBox.TabIndex = 0;
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(656, 231);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(121, 45);
            this.ColorButton.TabIndex = 3;
            this.ColorButton.Text = "Color";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Visible = false;
            this.ColorButton.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RectanglePanel);
            this.Controls.Add(this.InputPanel);
            this.Name = "Form3";
            this.Text = "Form3";
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RectanglePanel;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.ComboBox AngleBox;
        private System.Windows.Forms.TextBox SplitCountBox;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button ColorButton;
    }
}