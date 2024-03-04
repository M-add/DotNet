namespace Game
{
    partial class LevelCompletion
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
            this.LevelLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.NextButton = new Game.RoundButton();
            this.RetryButton = new Game.RoundButton();
            this.ExitButton = new Game.RoundButton();
            this.SuspendLayout();
            // 
            // LevelLabel
            // 
            this.LevelLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabel.Location = new System.Drawing.Point(0, 0);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(459, 55);
            this.LevelLabel.TabIndex = 0;
            this.LevelLabel.Text = "Level";
            this.LevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(0, 55);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(459, 55);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "Completed!!";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.DarkCyan;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(312, 119);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(109, 69);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "⏭";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButtonClick);
            // 
            // RetryButton
            // 
            this.RetryButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.RetryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RetryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetryButton.Location = new System.Drawing.Point(180, 119);
            this.RetryButton.Name = "RetryButton";
            this.RetryButton.Size = new System.Drawing.Size(109, 69);
            this.RetryButton.TabIndex = 3;
            this.RetryButton.Text = "↻";
            this.RetryButton.UseVisualStyleBackColor = false;
            this.RetryButton.Click += new System.EventHandler(this.RetryButtonClick);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Crimson;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(53, 119);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(109, 69);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "❌";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // LevelCompletion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 200);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.RetryButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.LevelLabel);
            this.MinimumSize = new System.Drawing.Size(475, 239);
            this.Name = "LevelCompletion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LevelCompletion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private RoundButton ExitButton;
        private RoundButton RetryButton;
        private RoundButton NextButton;
    }
}