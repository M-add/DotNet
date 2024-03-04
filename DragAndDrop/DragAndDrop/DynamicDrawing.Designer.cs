namespace DragAndDrop
{
    partial class DynamicDrawing
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
            this.InputPanel = new System.Windows.Forms.Panel();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.NumberBox = new System.Windows.Forms.RichTextBox();
            this.DropDown = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ColorButton = new System.Windows.Forms.Button();
            this.InputPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputPanel
            // 
            this.InputPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.InputPanel.Controls.Add(this.SubmitButton);
            this.InputPanel.Controls.Add(this.NumberBox);
            this.InputPanel.Controls.Add(this.DropDown);
            this.InputPanel.Controls.Add(this.panel1);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.InputPanel.Location = new System.Drawing.Point(628, 0);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(200, 540);
            this.InputPanel.TabIndex = 0;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.DarkGray;
            this.SubmitButton.ForeColor = System.Drawing.Color.Black;
            this.SubmitButton.Location = new System.Drawing.Point(36, 421);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(121, 48);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(36, 235);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(121, 72);
            this.NumberBox.TabIndex = 1;
            this.NumberBox.Text = "";
            // 
            // DropDown
            // 
            this.DropDown.FormattingEnabled = true;
            this.DropDown.Items.AddRange(new object[] {
            "Vertical",
            "Horizontal"});
            this.DropDown.Location = new System.Drawing.Point(36, 122);
            this.DropDown.Name = "DropDown";
            this.DropDown.Size = new System.Drawing.Size(121, 21);
            this.DropDown.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ColorButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 540);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(65, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "Click";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColorButton
            // 
            this.ColorButton.BackColor = System.Drawing.Color.Crimson;
            this.ColorButton.Location = new System.Drawing.Point(65, 160);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(75, 53);
            this.ColorButton.TabIndex = 0;
            this.ColorButton.Text = "Color";
            this.ColorButton.UseVisualStyleBackColor = false;
            // 
            // DynamicDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.InputPanel);
            this.Name = "DynamicDrawing";
            this.Size = new System.Drawing.Size(828, 540);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DynamicDrawing_MouseClick);
            this.InputPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.ComboBox DropDown;
        private System.Windows.Forms.RichTextBox NumberBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Button button1;
    }
}
