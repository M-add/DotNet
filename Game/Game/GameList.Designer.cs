namespace Game
{
    partial class GameList
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
            this.ChooseLabel = new System.Windows.Forms.Label();
            this.GamePanelOne = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GameOne = new Game.RoundButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GameTwo = new Game.RoundButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Dodgegame = new Game.RoundButton();
            this.roundButton1 = new Game.RoundButton();
            this.GamePanelOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseLabel
            // 
            this.ChooseLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.ChooseLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChooseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseLabel.Location = new System.Drawing.Point(0, 0);
            this.ChooseLabel.Name = "ChooseLabel";
            this.ChooseLabel.Size = new System.Drawing.Size(800, 91);
            this.ChooseLabel.TabIndex = 2;
            this.ChooseLabel.Text = "Choose a Game ";
            this.ChooseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GamePanelOne
            // 
            this.GamePanelOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(124)))), ((int)(((byte)(249)))));
            this.GamePanelOne.Controls.Add(this.pictureBox1);
            this.GamePanelOne.Controls.Add(this.GameOne);
            this.GamePanelOne.Location = new System.Drawing.Point(10, 94);
            this.GamePanelOne.Name = "GamePanelOne";
            this.GamePanelOne.Size = new System.Drawing.Size(150, 188);
            this.GamePanelOne.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(199)))), ((int)(((byte)(203)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Game.Properties.Resources.Assassin;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // GameOne
            // 
            this.GameOne.BackColor = System.Drawing.Color.DarkKhaki;
            this.GameOne.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GameOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOne.Location = new System.Drawing.Point(0, 125);
            this.GameOne.Name = "GameOne";
            this.GameOne.Size = new System.Drawing.Size(150, 63);
            this.GameOne.TabIndex = 0;
            this.GameOne.Text = "Monster Assassination";
            this.GameOne.UseVisualStyleBackColor = false;
            this.GameOne.Click += new System.EventHandler(this.GameOne_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(124)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.GameTwo);
            this.panel1.Location = new System.Drawing.Point(194, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 188);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(199)))), ((int)(((byte)(203)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Game.Properties.Resources.snake;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // GameTwo
            // 
            this.GameTwo.BackColor = System.Drawing.Color.DarkKhaki;
            this.GameTwo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GameTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameTwo.Location = new System.Drawing.Point(0, 125);
            this.GameTwo.Name = "GameTwo";
            this.GameTwo.Size = new System.Drawing.Size(150, 63);
            this.GameTwo.TabIndex = 0;
            this.GameTwo.Text = "Snake Game";
            this.GameTwo.UseVisualStyleBackColor = false;
            this.GameTwo.Click += new System.EventHandler(this.GameTwo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(124)))), ((int)(((byte)(249)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.Dodgegame);
            this.panel2.Location = new System.Drawing.Point(382, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 188);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(199)))), ((int)(((byte)(203)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 125);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // Dodgegame
            // 
            this.Dodgegame.BackColor = System.Drawing.Color.DarkKhaki;
            this.Dodgegame.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dodgegame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dodgegame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dodgegame.Location = new System.Drawing.Point(0, 125);
            this.Dodgegame.Name = "Dodgegame";
            this.Dodgegame.Size = new System.Drawing.Size(150, 63);
            this.Dodgegame.TabIndex = 0;
            this.Dodgegame.Text = "Dodge Game";
            this.Dodgegame.UseVisualStyleBackColor = false;
            this.Dodgegame.Click += new System.EventHandler(this.DodgeGameClick);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.DarkCyan;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Location = new System.Drawing.Point(581, 123);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(188, 59);
            this.roundButton1.TabIndex = 6;
            this.roundButton1.Text = "roundButton1";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // GameList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GamePanelOne);
            this.Controls.Add(this.ChooseLabel);
            this.Name = "GameList";
            this.Text = "GameList";
            this.GamePanelOne.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButton GameOne;
        private System.Windows.Forms.Label ChooseLabel;
        private System.Windows.Forms.Panel GamePanelOne;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RoundButton GameTwo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private RoundButton Dodgegame;
        private RoundButton roundButton1;
    }
}