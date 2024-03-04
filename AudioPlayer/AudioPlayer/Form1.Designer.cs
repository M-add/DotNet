namespace AudioPlayer
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
            this.SongPanel = new System.Windows.Forms.Panel();
            this.EndLabel = new System.Windows.Forms.Label();
            this.StartLabel = new System.Windows.Forms.Label();
            this.AlbumPicture = new System.Windows.Forms.PictureBox();
            this.PlaybackPanel = new System.Windows.Forms.Panel();
            this.NextButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.PlaybackButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SongButton = new System.Windows.Forms.Button();
            this.volumeSlider = new AudioPlayer.VerticalSlider();
            this.PlayBackBar = new AudioPlayer.VolumeSlider();
            this.MainPanel.SuspendLayout();
            this.SongPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumPicture)).BeginInit();
            this.PlaybackPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.SongPanel);
            this.MainPanel.Controls.Add(this.PlaybackPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 450);
            this.MainPanel.TabIndex = 0;
            // 
            // SongPanel
            // 
            this.SongPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SongPanel.Controls.Add(this.volumeSlider);
            this.SongPanel.Controls.Add(this.EndLabel);
            this.SongPanel.Controls.Add(this.StartLabel);
            this.SongPanel.Controls.Add(this.AlbumPicture);
            this.SongPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SongPanel.Location = new System.Drawing.Point(0, 0);
            this.SongPanel.Name = "SongPanel";
            this.SongPanel.Size = new System.Drawing.Size(800, 387);
            this.SongPanel.TabIndex = 1;
            // 
            // EndLabel
            // 
            this.EndLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EndLabel.AutoSize = true;
            this.EndLabel.Location = new System.Drawing.Point(763, 371);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(34, 13);
            this.EndLabel.TabIndex = 6;
            this.EndLabel.Text = "00:00";
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StartLabel.Location = new System.Drawing.Point(0, 374);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(34, 13);
            this.StartLabel.TabIndex = 1;
            this.StartLabel.Text = "00:00";
            // 
            // AlbumPicture
            // 
            this.AlbumPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlbumPicture.Image = global::AudioPlayer.Properties.Resources.tunes;
            this.AlbumPicture.Location = new System.Drawing.Point(0, 0);
            this.AlbumPicture.Name = "AlbumPicture";
            this.AlbumPicture.Size = new System.Drawing.Size(800, 387);
            this.AlbumPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AlbumPicture.TabIndex = 0;
            this.AlbumPicture.TabStop = false;
            this.AlbumPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // PlaybackPanel
            // 
            this.PlaybackPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PlaybackPanel.Controls.Add(this.NextButton);
            this.PlaybackPanel.Controls.Add(this.PrevButton);
            this.PlaybackPanel.Controls.Add(this.PlaybackButton);
            this.PlaybackPanel.Controls.Add(this.panel1);
            this.PlaybackPanel.Controls.Add(this.SongButton);
            this.PlaybackPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PlaybackPanel.Location = new System.Drawing.Point(0, 387);
            this.PlaybackPanel.Name = "PlaybackPanel";
            this.PlaybackPanel.Size = new System.Drawing.Size(800, 63);
            this.PlaybackPanel.TabIndex = 2;
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(460, 17);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(107, 41);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "⏭";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevButton.Location = new System.Drawing.Point(234, 17);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(107, 41);
            this.PrevButton.TabIndex = 4;
            this.PrevButton.Text = "⏮";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // PlaybackButton
            // 
            this.PlaybackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaybackButton.Location = new System.Drawing.Point(347, 18);
            this.PlaybackButton.Name = "PlaybackButton";
            this.PlaybackButton.Size = new System.Drawing.Size(107, 41);
            this.PlaybackButton.TabIndex = 2;
            this.PlaybackButton.Text = "▶";
            this.PlaybackButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PlaybackButton.UseVisualStyleBackColor = true;
            this.PlaybackButton.Click += new System.EventHandler(this.PlaybackButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PlayBackBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 16);
            this.panel1.TabIndex = 1;
            // 
            // SongButton
            // 
            this.SongButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongButton.Location = new System.Drawing.Point(3, 19);
            this.SongButton.Name = "SongButton";
            this.SongButton.Size = new System.Drawing.Size(107, 41);
            this.SongButton.TabIndex = 0;
            this.SongButton.Text = "♫";
            this.SongButton.UseVisualStyleBackColor = true;
            this.SongButton.Click += new System.EventHandler(this.PlaybackButtonClick);
            // 
            // volumeSlider
            // 
            this.volumeSlider.Location = new System.Drawing.Point(718, 51);
            this.volumeSlider.Maximum = 100F;
            this.volumeSlider.Minimum = 0F;
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(46, 300);
            this.volumeSlider.TabIndex = 7;
            this.volumeSlider.Value = 399F;
            // 
            // PlayBackBar
            // 
            this.PlayBackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayBackBar.Location = new System.Drawing.Point(0, 0);
            this.PlayBackBar.Maximum = 100F;
            this.PlayBackBar.Minimum = 0F;
            this.PlayBackBar.Name = "PlayBackBar";
            this.PlayBackBar.Size = new System.Drawing.Size(800, 16);
            this.PlayBackBar.SliderValue = 0F;
            this.PlayBackBar.TabIndex = 7;
            this.PlayBackBar.Value = 0F;
            this.PlayBackBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayBackBarMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPanel.ResumeLayout(false);
            this.SongPanel.ResumeLayout(false);
            this.SongPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumPicture)).EndInit();
            this.PlaybackPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button SongButton;
        private System.Windows.Forms.Panel SongPanel;
        private System.Windows.Forms.PictureBox AlbumPicture;
        private System.Windows.Forms.Panel PlaybackPanel;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button PlaybackButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label EndLabel;
        private VolumeSlider PlayBackBar;
        private VerticalSlider volumeSlider;
    }
}

