namespace userControl
{
    partial class UserControl1
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
            this.spinBox = new System.Windows.Forms.TextBox();
            this.up = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.down = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // spinBox
            // 
            this.spinBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spinBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinBox.Location = new System.Drawing.Point(0, 0);
            this.spinBox.Margin = new System.Windows.Forms.Padding(0);
            this.spinBox.Multiline = true;
            this.spinBox.Name = "spinBox";
            this.spinBox.Size = new System.Drawing.Size(373, 103);
            this.spinBox.TabIndex = 0;
            this.spinBox.Text = "0";
            this.spinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // up
            // 
            this.up.Dock = System.Windows.Forms.DockStyle.Fill;
            this.up.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up.Location = new System.Drawing.Point(3, 3);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(197, 45);
            this.up.TabIndex = 1;
            this.up.Text = "▲";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click_1);
            this.up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.up_MouseDown);
            this.up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.up_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.up, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.down, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(373, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(203, 103);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // down
            // 
            this.down.Dock = System.Windows.Forms.DockStyle.Fill;
            this.down.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.down.Location = new System.Drawing.Point(3, 54);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(197, 46);
            this.down.TabIndex = 2;
            this.down.Text = "▼";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            this.down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.down_MouseDown);
            this.down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.down_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.spinBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 103);
            this.panel1.TabIndex = 4;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.tableLayoutPanel1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(576, 103);
            this.MainPanel.TabIndex = 5;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(576, 103);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.Resize += new System.EventHandler(this.UserControl1_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox spinBox;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MainPanel;
    }
}
