namespace TicTacToe
{
    partial class Form2
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
            this.xoPanel = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.PictureBox();
            this.PlayerBox = new System.Windows.Forms.Label();
            this.xoBox = new TicTacToe.XO();
            this.xoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.SuspendLayout();
            // 
            // xoPanel
            // 
            this.xoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xoPanel.Controls.Add(this.xoBox);
            this.xoPanel.Location = new System.Drawing.Point(176, 148);
            this.xoPanel.Name = "xoPanel";
            this.xoPanel.Size = new System.Drawing.Size(827, 489);
            this.xoPanel.TabIndex = 2;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.Image = global::TicTacToe.Properties.Resources.back_arrow;
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(70, 70);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back.TabIndex = 3;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // PlayerBox
            // 
            this.PlayerBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerBox.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold);
            this.PlayerBox.Location = new System.Drawing.Point(171, 91);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(242, 38);
            this.PlayerBox.TabIndex = 4;
            this.PlayerBox.Text = "Player 1\'s turn";
            // 
            // xoBox
            // 
            this.xoBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.xoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xoBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.xoBox.Location = new System.Drawing.Point(0, 0);
            this.xoBox.Margin = new System.Windows.Forms.Padding(0);
            this.xoBox.Name = "xoBox";
            this.xoBox.Size = new System.Drawing.Size(827, 489);
            this.xoBox.TabIndex = 0;
            this.xoBox.Load += new System.EventHandler(this.xoBox_Load);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1084, 695);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.PlayerBox);
            this.Controls.Add(this.xoPanel);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.xoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel xoPanel;
        private System.Windows.Forms.PictureBox Back;
        private XO xoBox;
        private System.Windows.Forms.Label PlayerBox;
    }
}