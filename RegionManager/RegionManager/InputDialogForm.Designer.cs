namespace RegionManager
{
    partial class InputDialogForm
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
            this.XText = new System.Windows.Forms.TextBox();
            this.Xlabel = new System.Windows.Forms.Label();
            this.Ylabel = new System.Windows.Forms.Label();
            this.YText = new System.Windows.Forms.TextBox();
            this.InputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // XText
            // 
            this.XText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.XText.Location = new System.Drawing.Point(12, 55);
            this.XText.Multiline = true;
            this.XText.Name = "XText";
            this.XText.Size = new System.Drawing.Size(100, 48);
            this.XText.TabIndex = 0;
            // 
            // Xlabel
            // 
            this.Xlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Xlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xlabel.Location = new System.Drawing.Point(12, 19);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(100, 23);
            this.Xlabel.TabIndex = 2;
            this.Xlabel.Text = "Enter X  Value:-";
            this.Xlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ylabel
            // 
            this.Ylabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ylabel.Location = new System.Drawing.Point(155, 19);
            this.Ylabel.Name = "Ylabel";
            this.Ylabel.Size = new System.Drawing.Size(100, 23);
            this.Ylabel.TabIndex = 4;
            this.Ylabel.Text = "Enter Y  Value:-";
            this.Ylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YText
            // 
            this.YText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YText.Location = new System.Drawing.Point(155, 55);
            this.YText.Multiline = true;
            this.YText.Name = "YText";
            this.YText.Size = new System.Drawing.Size(100, 48);
            this.YText.TabIndex = 3;
            // 
            // InputButton
            // 
            this.InputButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputButton.Location = new System.Drawing.Point(30, 132);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(200, 32);
            this.InputButton.TabIndex = 5;
            this.InputButton.Text = "Ok";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // InputDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 176);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.Ylabel);
            this.Controls.Add(this.YText);
            this.Controls.Add(this.Xlabel);
            this.Controls.Add(this.XText);
            this.Name = "InputDialogForm";
            this.Text = "InputDialogForm";
            this.Load += new System.EventHandler(this.InputDialogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox XText;
        private System.Windows.Forms.Label Xlabel;
        private System.Windows.Forms.Label Ylabel;
        private System.Windows.Forms.TextBox YText;
        private System.Windows.Forms.Button InputButton;
    }
}