namespace Drawing_MAnager
{
    partial class Scale
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.SizeSubmitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HeightBox);
            this.panel1.Controls.Add(this.HeightLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(94, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 95);
            this.panel1.TabIndex = 0;
            // 
            // HeightBox
            // 
            this.HeightBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightBox.Location = new System.Drawing.Point(0, 38);
            this.HeightBox.Multiline = true;
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(100, 57);
            this.HeightBox.TabIndex = 1;
            this.HeightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(0, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(100, 38);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = "Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.WidthBox);
            this.panel2.Controls.Add(this.WidthLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 95);
            this.panel2.TabIndex = 2;
            // 
            // WidthBox
            // 
            this.WidthBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WidthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthBox.Location = new System.Drawing.Point(0, 38);
            this.WidthBox.Multiline = true;
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(100, 57);
            this.WidthBox.TabIndex = 1;
            this.WidthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WidthLabel
            // 
            this.WidthLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthLabel.Location = new System.Drawing.Point(0, 0);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(100, 38);
            this.WidthLabel.TabIndex = 0;
            this.WidthLabel.Text = "Width";
            this.WidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SizeSubmitButton
            // 
            this.SizeSubmitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SizeSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeSubmitButton.Location = new System.Drawing.Point(0, 95);
            this.SizeSubmitButton.Name = "SizeSubmitButton";
            this.SizeSubmitButton.Size = new System.Drawing.Size(194, 34);
            this.SizeSubmitButton.TabIndex = 4;
            this.SizeSubmitButton.Text = "Submit";
            this.SizeSubmitButton.UseVisualStyleBackColor = true;
            this.SizeSubmitButton.Click += new System.EventHandler(this.SizeSubmitButtonClick);
            // 
            // Scale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SizeSubmitButton);
            this.Name = "Scale";
            this.Size = new System.Drawing.Size(194, 129);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Button SizeSubmitButton;
    }
}
