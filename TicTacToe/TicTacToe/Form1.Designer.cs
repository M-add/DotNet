namespace TicTacToe
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.ExitButton = new TicTacToe.RoundButton();
            this.PlayButton = new TicTacToe.RoundButton();
            this.PicturePanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.PicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Cornsilk;
            this.MainPanel.Controls.Add(this.NoteLabel);
            this.MainPanel.Controls.Add(this.ExitButton);
            this.MainPanel.Controls.Add(this.PlayButton);
            this.MainPanel.Controls.Add(this.PicturePanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1066, 711);
            this.MainPanel.TabIndex = 0;
            // 
            // NoteLabel
            // 
            this.NoteLabel.BackColor = System.Drawing.Color.PapayaWhip;
            this.NoteLabel.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteLabel.Location = new System.Drawing.Point(885, 635);
            this.NoteLabel.Margin = new System.Windows.Forms.Padding(3);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(169, 67);
            this.NoteLabel.TabIndex = 3;
            this.NoteLabel.Text = "Note:-\r\n ->Player 1 -X\r\n ->Player 2 - O\r\n\r\n\r\n\r\n\r\n\r\n              ";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Crimson;
            this.ExitButton.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(405, 449);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(219, 103);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            this.ExitButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ExitButton_MouseMove);
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.PlayButton.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(405, 315);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(0);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(219, 103);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            this.PlayButton.MouseLeave += new System.EventHandler(this.PlayButton_MouseLeave);
            this.PlayButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PlayButton_MouseMove);
            // 
            // PicturePanel
            // 
            this.PicturePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicturePanel.Controls.Add(this.pictureBox);
            this.PicturePanel.Location = new System.Drawing.Point(382, 12);
            this.PicturePanel.Name = "PicturePanel";
            this.PicturePanel.Size = new System.Drawing.Size(271, 151);
            this.PicturePanel.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = global::TicTacToe.Properties.Resources.XO;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(267, 147);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 711);
            this.Controls.Add(this.MainPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.MainPanel.ResumeLayout(false);
            this.PicturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel PicturePanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private RoundButton PlayButton;
        private RoundButton ExitButton;
        private System.Windows.Forms.Label NoteLabel;
    }
}

