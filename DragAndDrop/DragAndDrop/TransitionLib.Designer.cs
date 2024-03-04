namespace DragAndDrop
{
    partial class TransitionLib
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
            this.Gi = new System.Windows.Forms.PictureBox();
            this.Paimon = new System.Windows.Forms.PictureBox();
            this.ripple1 = new DragAndDrop.Ripple();
            this.rippleButton2 = new DragAndDrop.RippleButton();
            this.rippleButton1 = new DragAndDrop.RippleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Gi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paimon)).BeginInit();
            this.SuspendLayout();
            // 
            // Gi
            // 
            this.Gi.Image = global::DragAndDrop.Properties.Resources.GI;
            this.Gi.Location = new System.Drawing.Point(678, 353);
            this.Gi.Name = "Gi";
            this.Gi.Size = new System.Drawing.Size(100, 74);
            this.Gi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Gi.TabIndex = 1;
            this.Gi.TabStop = false;
            // 
            // Paimon
            // 
            this.Paimon.Image = global::DragAndDrop.Properties.Resources.paimon;
            this.Paimon.Location = new System.Drawing.Point(12, 12);
            this.Paimon.Name = "Paimon";
            this.Paimon.Size = new System.Drawing.Size(100, 74);
            this.Paimon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Paimon.TabIndex = 0;
            this.Paimon.TabStop = false;
            // 
            // ripple1
            // 
            this.ripple1.BackColor = System.Drawing.Color.Chocolate;
            this.ripple1.Location = new System.Drawing.Point(562, 12);
            this.ripple1.Name = "ripple1";
            this.ripple1.Size = new System.Drawing.Size(216, 105);
            this.ripple1.TabIndex = 3;
            // 
            // rippleButton2
            // 
            this.rippleButton2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rippleButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rippleButton2.Location = new System.Drawing.Point(209, 249);
            this.rippleButton2.Name = "rippleButton2";
            this.rippleButton2.RippleColor = System.Drawing.Color.CornflowerBlue;
            this.rippleButton2.Size = new System.Drawing.Size(265, 137);
            this.rippleButton2.TabIndex = 4;
            this.rippleButton2.Text = "rippleButton2";
            this.rippleButton2.UseVisualStyleBackColor = false;
            // 
            // rippleButton1
            // 
            this.rippleButton1.Alpha = 250;
            this.rippleButton1.BackColor = System.Drawing.Color.GreenYellow;
            this.rippleButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rippleButton1.Location = new System.Drawing.Point(153, 83);
            this.rippleButton1.Name = "rippleButton1";
            this.rippleButton1.RippleColor = System.Drawing.Color.GreenYellow;
            this.rippleButton1.Size = new System.Drawing.Size(163, 68);
            this.rippleButton1.TabIndex = 5;
            this.rippleButton1.Text = "CLICK!";
            this.rippleButton1.UseVisualStyleBackColor = false;
            // 
            // TransitionLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rippleButton1);
            this.Controls.Add(this.rippleButton2);
            this.Controls.Add(this.ripple1);
            this.Controls.Add(this.Gi);
            this.Controls.Add(this.Paimon);
            this.Name = "TransitionLib";
            this.Text = "TransitionLib";
            this.Click += new System.EventHandler(this.TransitionLibClick);
            ((System.ComponentModel.ISupportInitialize)(this.Gi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paimon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Gi;
        private System.Windows.Forms.PictureBox Paimon;
        private Ripple ripple1;
        private RippleButton rippleButton2;
        private RippleButton rippleButton1;
    }
}