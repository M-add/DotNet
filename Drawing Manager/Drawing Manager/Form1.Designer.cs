namespace Drawing_MAnager
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
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.RedoButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.UndoButton = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FlipYButton = new System.Windows.Forms.Button();
            this.ColorButton = new System.Windows.Forms.Button();
            this.RotateLeft = new System.Windows.Forms.Button();
            this.scaleControl = new Drawing_MAnager.Scale();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FlipXButton = new System.Windows.Forms.Button();
            this.BrushButton = new System.Windows.Forms.Button();
            this.RotateRight = new System.Windows.Forms.Button();
            this.MoveObjects = new System.Windows.Forms.Panel();
            this.BlackPictureBox = new System.Windows.Forms.PictureBox();
            this.RightButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.TopButton = new System.Windows.Forms.Button();
            this.EraseButton = new System.Windows.Forms.Button();
            this.ToolsLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.ObjectPanel = new System.Windows.Forms.Panel();
            this.ObjectLabel = new System.Windows.Forms.Label();
            this.discordVoiceNote1 = new Drawing_MAnager.DiscordVoiceNote();
            this.MainPanel.SuspendLayout();
            this.DrawingPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.SidePanel.SuspendLayout();
            this.ToolPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MoveObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlackPictureBox)).BeginInit();
            this.ObjectPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainPanel.Controls.Add(this.DrawingPanel);
            this.MainPanel.Controls.Add(this.MenuPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1197, 805);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawingPanelMouseClick);
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.Controls.Add(this.discordVoiceNote1);
            this.DrawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawingPanel.Location = new System.Drawing.Point(0, 28);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(1197, 777);
            this.DrawingPanel.TabIndex = 1;
            this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            this.DrawingPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawingPanelMouseClick);
            this.DrawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingPanelMouseDown);
            this.DrawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingPanelMouseMove);
            this.DrawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingPanelMouseUp);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MenuPanel.Controls.Add(this.button1);
            this.MenuPanel.Controls.Add(this.RedoButton);
            this.MenuPanel.Controls.Add(this.SaveButton);
            this.MenuPanel.Controls.Add(this.UndoButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1197, 28);
            this.MenuPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1151, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "=>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RedoButton
            // 
            this.RedoButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.RedoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedoButton.Location = new System.Drawing.Point(298, 0);
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(149, 28);
            this.RedoButton.TabIndex = 2;
            this.RedoButton.Text = "Redo";
            this.RedoButton.UseVisualStyleBackColor = true;
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(149, 0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(149, 28);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // UndoButton
            // 
            this.UndoButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.UndoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UndoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UndoButton.Location = new System.Drawing.Point(0, 0);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(149, 28);
            this.UndoButton.TabIndex = 1;
            this.UndoButton.Text = "Undo";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.Controls.Add(this.ToolPanel);
            this.SidePanel.Controls.Add(this.AddButton);
            this.SidePanel.Controls.Add(this.ObjectPanel);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SidePanel.Location = new System.Drawing.Point(846, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(351, 805);
            this.SidePanel.TabIndex = 1;
            // 
            // ToolPanel
            // 
            this.ToolPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ToolPanel.Controls.Add(this.panel2);
            this.ToolPanel.Controls.Add(this.panel1);
            this.ToolPanel.Controls.Add(this.EraseButton);
            this.ToolPanel.Controls.Add(this.ToolsLabel);
            this.ToolPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolPanel.Location = new System.Drawing.Point(0, 321);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Size = new System.Drawing.Size(351, 484);
            this.ToolPanel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.FlipYButton);
            this.panel2.Controls.Add(this.ColorButton);
            this.panel2.Controls.Add(this.RotateLeft);
            this.panel2.Controls.Add(this.scaleControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 396);
            this.panel2.TabIndex = 9;
            // 
            // FlipYButton
            // 
            this.FlipYButton.BackColor = System.Drawing.Color.Cornsilk;
            this.FlipYButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlipYButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlipYButton.Location = new System.Drawing.Point(0, 290);
            this.FlipYButton.Name = "FlipYButton";
            this.FlipYButton.Size = new System.Drawing.Size(151, 106);
            this.FlipYButton.TabIndex = 6;
            this.FlipYButton.Text = "Flip Y";
            this.FlipYButton.UseVisualStyleBackColor = false;
            this.FlipYButton.Click += new System.EventHandler(this.FlipYButtonClick);
            // 
            // ColorButton
            // 
            this.ColorButton.BackColor = System.Drawing.Color.Cornsilk;
            this.ColorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorButton.Location = new System.Drawing.Point(0, 212);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(151, 78);
            this.ColorButton.TabIndex = 9;
            this.ColorButton.Text = "Color";
            this.ColorButton.UseVisualStyleBackColor = false;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // RotateLeft
            // 
            this.RotateLeft.BackColor = System.Drawing.Color.Cornsilk;
            this.RotateLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.RotateLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotateLeft.Location = new System.Drawing.Point(0, 122);
            this.RotateLeft.Name = "RotateLeft";
            this.RotateLeft.Size = new System.Drawing.Size(151, 90);
            this.RotateLeft.TabIndex = 4;
            this.RotateLeft.Text = "Rotate 90 ° Left";
            this.RotateLeft.UseVisualStyleBackColor = false;
            this.RotateLeft.Click += new System.EventHandler(this.RotateLeftClick);
            // 
            // scaleControl
            // 
            this.scaleControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.scaleControl.HeightChange = 0;
            this.scaleControl.Location = new System.Drawing.Point(0, 0);
            this.scaleControl.Name = "scaleControl";
            this.scaleControl.Size = new System.Drawing.Size(151, 122);
            this.scaleControl.SubmitButtonColor = System.Drawing.Color.AliceBlue;
            this.scaleControl.TabIndex = 1;
            this.scaleControl.WidthChange = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FlipXButton);
            this.panel1.Controls.Add(this.BrushButton);
            this.panel1.Controls.Add(this.RotateRight);
            this.panel1.Controls.Add(this.MoveObjects);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 396);
            this.panel1.TabIndex = 8;
            // 
            // FlipXButton
            // 
            this.FlipXButton.BackColor = System.Drawing.Color.Cornsilk;
            this.FlipXButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlipXButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlipXButton.Location = new System.Drawing.Point(0, 290);
            this.FlipXButton.Name = "FlipXButton";
            this.FlipXButton.Size = new System.Drawing.Size(200, 106);
            this.FlipXButton.TabIndex = 5;
            this.FlipXButton.Text = "Flip X";
            this.FlipXButton.UseVisualStyleBackColor = false;
            this.FlipXButton.Click += new System.EventHandler(this.FlipXButtonClick);
            // 
            // BrushButton
            // 
            this.BrushButton.BackColor = System.Drawing.Color.Cornsilk;
            this.BrushButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BrushButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrushButton.Location = new System.Drawing.Point(0, 212);
            this.BrushButton.Name = "BrushButton";
            this.BrushButton.Size = new System.Drawing.Size(200, 78);
            this.BrushButton.TabIndex = 8;
            this.BrushButton.Text = "Brush";
            this.BrushButton.UseVisualStyleBackColor = false;
            this.BrushButton.Click += new System.EventHandler(this.BrushButtonClick);
            // 
            // RotateRight
            // 
            this.RotateRight.BackColor = System.Drawing.Color.Cornsilk;
            this.RotateRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.RotateRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotateRight.Location = new System.Drawing.Point(0, 122);
            this.RotateRight.Name = "RotateRight";
            this.RotateRight.Size = new System.Drawing.Size(200, 90);
            this.RotateRight.TabIndex = 3;
            this.RotateRight.Text = "Rotate 90 ° Right";
            this.RotateRight.UseVisualStyleBackColor = false;
            this.RotateRight.Click += new System.EventHandler(this.RotateRightClick);
            // 
            // MoveObjects
            // 
            this.MoveObjects.Controls.Add(this.BlackPictureBox);
            this.MoveObjects.Controls.Add(this.RightButton);
            this.MoveObjects.Controls.Add(this.LeftButton);
            this.MoveObjects.Controls.Add(this.DownButton);
            this.MoveObjects.Controls.Add(this.TopButton);
            this.MoveObjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.MoveObjects.Location = new System.Drawing.Point(0, 0);
            this.MoveObjects.Name = "MoveObjects";
            this.MoveObjects.Size = new System.Drawing.Size(200, 122);
            this.MoveObjects.TabIndex = 2;
            // 
            // BlackPictureBox
            // 
            this.BlackPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.BlackPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BlackPictureBox.Image = global::Drawing_MAnager.Properties.Resources.Black1;
            this.BlackPictureBox.Location = new System.Drawing.Point(66, 38);
            this.BlackPictureBox.Name = "BlackPictureBox";
            this.BlackPictureBox.Size = new System.Drawing.Size(68, 48);
            this.BlackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BlackPictureBox.TabIndex = 5;
            this.BlackPictureBox.TabStop = false;
            // 
            // RightButton
            // 
            this.RightButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightButton.Location = new System.Drawing.Point(134, 38);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(66, 48);
            this.RightButton.TabIndex = 4;
            this.RightButton.Text = "▶";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButtonClick);
            // 
            // LeftButton
            // 
            this.LeftButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftButton.Location = new System.Drawing.Point(0, 38);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(66, 48);
            this.LeftButton.TabIndex = 3;
            this.LeftButton.Text = "◀";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButtonClick);
            // 
            // DownButton
            // 
            this.DownButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownButton.Location = new System.Drawing.Point(0, 86);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(200, 36);
            this.DownButton.TabIndex = 2;
            this.DownButton.Text = "▼";
            this.DownButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButtonClick);
            // 
            // TopButton
            // 
            this.TopButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopButton.Location = new System.Drawing.Point(0, 0);
            this.TopButton.Name = "TopButton";
            this.TopButton.Size = new System.Drawing.Size(200, 38);
            this.TopButton.TabIndex = 1;
            this.TopButton.Text = "▲";
            this.TopButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TopButton.UseVisualStyleBackColor = true;
            this.TopButton.Click += new System.EventHandler(this.TopButtonClick);
            // 
            // EraseButton
            // 
            this.EraseButton.BackColor = System.Drawing.Color.Cornsilk;
            this.EraseButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EraseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EraseButton.Location = new System.Drawing.Point(0, 424);
            this.EraseButton.Name = "EraseButton";
            this.EraseButton.Size = new System.Drawing.Size(351, 60);
            this.EraseButton.TabIndex = 7;
            this.EraseButton.Text = "Erase";
            this.EraseButton.UseVisualStyleBackColor = false;
            this.EraseButton.Click += new System.EventHandler(this.EraseButtonClick);
            // 
            // ToolsLabel
            // 
            this.ToolsLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToolsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolsLabel.Location = new System.Drawing.Point(0, 0);
            this.ToolsLabel.Name = "ToolsLabel";
            this.ToolsLabel.Size = new System.Drawing.Size(351, 28);
            this.ToolsLabel.TabIndex = 1;
            this.ToolsLabel.Text = "Tools";
            this.ToolsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(0, 285);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(351, 36);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // ObjectPanel
            // 
            this.ObjectPanel.AutoScroll = true;
            this.ObjectPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ObjectPanel.Controls.Add(this.ObjectLabel);
            this.ObjectPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ObjectPanel.Location = new System.Drawing.Point(0, 0);
            this.ObjectPanel.Name = "ObjectPanel";
            this.ObjectPanel.Size = new System.Drawing.Size(351, 285);
            this.ObjectPanel.TabIndex = 2;
            // 
            // ObjectLabel
            // 
            this.ObjectLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ObjectLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ObjectLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ObjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjectLabel.Location = new System.Drawing.Point(0, 0);
            this.ObjectLabel.Name = "ObjectLabel";
            this.ObjectLabel.Size = new System.Drawing.Size(351, 28);
            this.ObjectLabel.TabIndex = 0;
            this.ObjectLabel.Text = "Objects";
            this.ObjectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // discordVoiceNote1
            // 
            this.discordVoiceNote1.Location = new System.Drawing.Point(234, 179);
            this.discordVoiceNote1.Name = "discordVoiceNote1";
            this.discordVoiceNote1.Size = new System.Drawing.Size(150, 58);
            this.discordVoiceNote1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 805);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.MainPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPanel.ResumeLayout(false);
            this.DrawingPanel.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            this.ToolPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.MoveObjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BlackPictureBox)).EndInit();
            this.ObjectPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.Button RedoButton;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel ToolPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button FlipYButton;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Button RotateLeft;
        private Scale scaleControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FlipXButton;
        private System.Windows.Forms.Button BrushButton;
        private System.Windows.Forms.Button RotateRight;
        private System.Windows.Forms.Panel MoveObjects;
        private System.Windows.Forms.PictureBox BlackPictureBox;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button TopButton;
        private System.Windows.Forms.Button EraseButton;
        private System.Windows.Forms.Label ToolsLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel ObjectPanel;
        private System.Windows.Forms.Label ObjectLabel;
        private DiscordVoiceNote discordVoiceNote1;
    }
}

