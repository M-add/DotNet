namespace RegionManager
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
            this.Drawpanel = new System.Windows.Forms.Panel();
            this.DrawButton = new System.Windows.Forms.Button();
            this.ShapePanel = new System.Windows.Forms.Panel();
            this.ShapeComboBox = new System.Windows.Forms.ComboBox();
            this.ShapeLabel = new System.Windows.Forms.Label();
            this.InputButton = new System.Windows.Forms.Button();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.ChooseButton = new System.Windows.Forms.Button();
            this.FunctionPanel = new System.Windows.Forms.Panel();
            this.Functionlabel = new System.Windows.Forms.Label();
            this.GetWidthButton = new System.Windows.Forms.Button();
            this.MoveButton = new System.Windows.Forms.Button();
            this.ResizeButton = new System.Windows.Forms.Button();
            this.IntersectButton = new System.Windows.Forms.Button();
            this.ShapePanel.SuspendLayout();
            this.InputPanel.SuspendLayout();
            this.FunctionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Drawpanel
            // 
            this.Drawpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Drawpanel.Location = new System.Drawing.Point(0, 0);
            this.Drawpanel.Name = "Drawpanel";
            this.Drawpanel.Size = new System.Drawing.Size(512, 411);
            this.Drawpanel.TabIndex = 4;
            this.Drawpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Drawpanel_Paint);
            // 
            // DrawButton
            // 
            this.DrawButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawButton.Location = new System.Drawing.Point(0, 411);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(512, 39);
            this.DrawButton.TabIndex = 3;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // ShapePanel
            // 
            this.ShapePanel.BackColor = System.Drawing.Color.DarkGray;
            this.ShapePanel.Controls.Add(this.InputButton);
            this.ShapePanel.Controls.Add(this.ShapeLabel);
            this.ShapePanel.Controls.Add(this.ShapeComboBox);
            this.ShapePanel.Location = new System.Drawing.Point(6, 12);
            this.ShapePanel.Name = "ShapePanel";
            this.ShapePanel.Size = new System.Drawing.Size(279, 138);
            this.ShapePanel.TabIndex = 0;
            // 
            // ShapeComboBox
            // 
            this.ShapeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ShapeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShapeComboBox.FormattingEnabled = true;
            this.ShapeComboBox.Items.AddRange(new object[] {
            "Circle",
            "Rectangle",
            "Triangle"});
            this.ShapeComboBox.Location = new System.Drawing.Point(45, 51);
            this.ShapeComboBox.Name = "ShapeComboBox";
            this.ShapeComboBox.Size = new System.Drawing.Size(194, 24);
            this.ShapeComboBox.TabIndex = 0;
            // 
            // ShapeLabel
            // 
            this.ShapeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ShapeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShapeLabel.Location = new System.Drawing.Point(45, 14);
            this.ShapeLabel.Name = "ShapeLabel";
            this.ShapeLabel.Size = new System.Drawing.Size(191, 23);
            this.ShapeLabel.TabIndex = 1;
            this.ShapeLabel.Text = "Choose Shape :-";
            this.ShapeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputButton
            // 
            this.InputButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputButton.Location = new System.Drawing.Point(41, 94);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(200, 32);
            this.InputButton.TabIndex = 2;
            this.InputButton.Text = "Ok";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButtonClick);
            // 
            // InputPanel
            // 
            this.InputPanel.AutoScroll = true;
            this.InputPanel.BackColor = System.Drawing.Color.DarkRed;
            this.InputPanel.Controls.Add(this.FunctionPanel);
            this.InputPanel.Controls.Add(this.ChooseButton);
            this.InputPanel.Controls.Add(this.ShapePanel);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.InputPanel.Location = new System.Drawing.Point(512, 0);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(288, 450);
            this.InputPanel.TabIndex = 0;
            // 
            // ChooseButton
            // 
            this.ChooseButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ChooseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseButton.Location = new System.Drawing.Point(0, 411);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(288, 39);
            this.ChooseButton.TabIndex = 7;
            this.ChooseButton.Text = "Choose Diffrent Shape";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // FunctionPanel
            // 
            this.FunctionPanel.BackColor = System.Drawing.Color.DarkGray;
            this.FunctionPanel.Controls.Add(this.IntersectButton);
            this.FunctionPanel.Controls.Add(this.ResizeButton);
            this.FunctionPanel.Controls.Add(this.MoveButton);
            this.FunctionPanel.Controls.Add(this.GetWidthButton);
            this.FunctionPanel.Controls.Add(this.Functionlabel);
            this.FunctionPanel.Location = new System.Drawing.Point(6, 156);
            this.FunctionPanel.Name = "FunctionPanel";
            this.FunctionPanel.Size = new System.Drawing.Size(279, 249);
            this.FunctionPanel.TabIndex = 8;
            // 
            // Functionlabel
            // 
            this.Functionlabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Functionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Functionlabel.Location = new System.Drawing.Point(0, 0);
            this.Functionlabel.Name = "Functionlabel";
            this.Functionlabel.Size = new System.Drawing.Size(279, 31);
            this.Functionlabel.TabIndex = 2;
            this.Functionlabel.Text = "Functions ";
            this.Functionlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GetWidthButton
            // 
            this.GetWidthButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.GetWidthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetWidthButton.Location = new System.Drawing.Point(3, 57);
            this.GetWidthButton.Name = "GetWidthButton";
            this.GetWidthButton.Size = new System.Drawing.Size(273, 32);
            this.GetWidthButton.TabIndex = 3;
            this.GetWidthButton.Text = "Get Width";
            this.GetWidthButton.UseVisualStyleBackColor = true;
            // 
            // MoveButton
            // 
            this.MoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveButton.Location = new System.Drawing.Point(3, 107);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(273, 32);
            this.MoveButton.TabIndex = 4;
            this.MoveButton.Text = "Move Region";
            this.MoveButton.UseVisualStyleBackColor = true;
            // 
            // ResizeButton
            // 
            this.ResizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ResizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResizeButton.Location = new System.Drawing.Point(3, 158);
            this.ResizeButton.Name = "ResizeButton";
            this.ResizeButton.Size = new System.Drawing.Size(273, 32);
            this.ResizeButton.TabIndex = 5;
            this.ResizeButton.Text = "Resize";
            this.ResizeButton.UseVisualStyleBackColor = true;
            // 
            // IntersectButton
            // 
            this.IntersectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.IntersectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntersectButton.Location = new System.Drawing.Point(3, 205);
            this.IntersectButton.Name = "IntersectButton";
            this.IntersectButton.Size = new System.Drawing.Size(273, 32);
            this.IntersectButton.TabIndex = 6;
            this.IntersectButton.Text = "Check Intersect";
            this.IntersectButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Drawpanel);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.InputPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ShapePanel.ResumeLayout(false);
            this.InputPanel.ResumeLayout(false);
            this.FunctionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Drawpanel;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.Panel ShapePanel;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.Label ShapeLabel;
        private System.Windows.Forms.ComboBox ShapeComboBox;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.Button ChooseButton;
        private System.Windows.Forms.Panel FunctionPanel;
        private System.Windows.Forms.Label Functionlabel;
        private System.Windows.Forms.Button IntersectButton;
        private System.Windows.Forms.Button ResizeButton;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Button GetWidthButton;
    }
}

