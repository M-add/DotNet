namespace Graphics
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
            this.themeText = new System.Windows.Forms.Label();
            this.theme = new Graphics.Toggle();
            this.SuspendLayout();
            // 
            // themeText
            // 
            this.themeText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.themeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeText.ForeColor = System.Drawing.Color.Black;
            this.themeText.Location = new System.Drawing.Point(1, 4);
            this.themeText.Name = "themeText";
            this.themeText.Size = new System.Drawing.Size(111, 24);
            this.themeText.TabIndex = 2;
            this.themeText.Text = "Dark Theme";
            // 
            // theme
            // 
            this.theme.ForeColor = System.Drawing.SystemColors.ControlText;
            this.theme.Location = new System.Drawing.Point(12, 31);
            this.theme.MinimumSize = new System.Drawing.Size(55, 32);
            this.theme.Name = "theme";
            this.theme.OffBackColor = System.Drawing.Color.Silver;
            this.theme.OffToggleColor = System.Drawing.Color.Snow;
            this.theme.OnBackColor = System.Drawing.Color.SteelBlue;
            this.theme.OnToggleColor = System.Drawing.SystemColors.ButtonHighlight;
            this.theme.Size = new System.Drawing.Size(100, 46);
            this.theme.TabIndex = 1;
            this.theme.Text = "toggle2";
            this.theme.UseVisualStyleBackColor = true;
            this.theme.CheckedChanged += new System.EventHandler(this.theme_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1095, 700);
            this.Controls.Add(this.theme);
            this.Controls.Add(this.themeText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Toggle theme;
        private System.Windows.Forms.Label themeText;
    }
}

