namespace DragAndDrop
{
    partial class ColorPicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorPicker));
            this.FillPanel = new System.Windows.Forms.Panel();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ColorValuePanel = new System.Windows.Forms.Panel();
            this.Colorpanel = new System.Windows.Forms.Panel();
            this.LinePanel = new System.Windows.Forms.Panel();
            this.AdjustPanel = new System.Windows.Forms.Panel();
            this.RedPanel = new System.Windows.Forms.Panel();
            this.RedValue = new System.Windows.Forms.Label();
            this.RedSlider = new DragAndDrop.VolumeSlider();
            this.Red = new System.Windows.Forms.Label();
            this.Green = new System.Windows.Forms.Label();
            this.Blue = new System.Windows.Forms.Label();
            this.GreenPanel = new System.Windows.Forms.Panel();
            this.GreenValue = new System.Windows.Forms.Label();
            this.GreenSlider = new DragAndDrop.VolumeSlider();
            this.BluePanel = new System.Windows.Forms.Panel();
            this.BlueValue = new System.Windows.Forms.Label();
            this.BlueSlider = new DragAndDrop.VolumeSlider();
            this.FramePanel = new System.Windows.Forms.Panel();
            this.CustomColorValue = new System.Windows.Forms.Button();
            this.Colorpanel.SuspendLayout();
            this.RedPanel.SuspendLayout();
            this.GreenPanel.SuspendLayout();
            this.BluePanel.SuspendLayout();
            this.FramePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FillPanel
            // 
            this.FillPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FillPanel.BackColor = System.Drawing.Color.Turquoise;
            this.FillPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FillPanel.Location = new System.Drawing.Point(18, 20);
            this.FillPanel.Name = "FillPanel";
            this.FillPanel.Size = new System.Drawing.Size(163, 151);
            this.FillPanel.TabIndex = 2;
            // 
            // ColorLabel
            // 
            this.ColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorLabel.Location = new System.Drawing.Point(12, 204);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(201, 23);
            this.ColorLabel.TabIndex = 3;
            this.ColorLabel.Text = "Color";
            this.ColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorValuePanel
            // 
            this.ColorValuePanel.AutoScroll = true;
            this.ColorValuePanel.BackColor = System.Drawing.Color.White;
            this.ColorValuePanel.Location = new System.Drawing.Point(403, 12);
            this.ColorValuePanel.Name = "ColorValuePanel";
            this.ColorValuePanel.Size = new System.Drawing.Size(385, 232);
            this.ColorValuePanel.TabIndex = 4;
            // 
            // Colorpanel
            // 
            this.Colorpanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Colorpanel.Controls.Add(this.FillPanel);
            this.Colorpanel.Location = new System.Drawing.Point(16, 13);
            this.Colorpanel.Name = "Colorpanel";
            this.Colorpanel.Size = new System.Drawing.Size(200, 188);
            this.Colorpanel.TabIndex = 6;
            // 
            // LinePanel
            // 
            this.LinePanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LinePanel.Location = new System.Drawing.Point(13, 250);
            this.LinePanel.Name = "LinePanel";
            this.LinePanel.Size = new System.Drawing.Size(782, 10);
            this.LinePanel.TabIndex = 7;
            // 
            // AdjustPanel
            // 
            this.AdjustPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AdjustPanel.Location = new System.Drawing.Point(4, 5);
            this.AdjustPanel.Margin = new System.Windows.Forms.Padding(30);
            this.AdjustPanel.Name = "AdjustPanel";
            this.AdjustPanel.Padding = new System.Windows.Forms.Padding(5);
            this.AdjustPanel.Size = new System.Drawing.Size(193, 165);
            this.AdjustPanel.TabIndex = 8;
            // 
            // RedPanel
            // 
            this.RedPanel.Controls.Add(this.RedValue);
            this.RedPanel.Controls.Add(this.RedSlider);
            this.RedPanel.Location = new System.Drawing.Point(299, 300);
            this.RedPanel.Name = "RedPanel";
            this.RedPanel.Size = new System.Drawing.Size(489, 44);
            this.RedPanel.TabIndex = 9;
            // 
            // RedValue
            // 
            this.RedValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedValue.Location = new System.Drawing.Point(448, 0);
            this.RedValue.Name = "RedValue";
            this.RedValue.Size = new System.Drawing.Size(41, 44);
            this.RedValue.TabIndex = 12;
            this.RedValue.Text = "0";
            this.RedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RedSlider
            // 
            this.RedSlider.Dock = System.Windows.Forms.DockStyle.Left;
            this.RedSlider.Location = new System.Drawing.Point(0, 0);
            this.RedSlider.Max = 255F;
            this.RedSlider.Min = 0F;
            this.RedSlider.Name = "RedSlider";
            this.RedSlider.Size = new System.Drawing.Size(448, 44);
            this.RedSlider.SliderValue = 0F;
            this.RedSlider.TabIndex = 11;
            this.RedSlider.ValueChanged += new System.EventHandler<float>(this.RedSlider_ValueChanged);
            // 
            // Red
            // 
            this.Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Red.Location = new System.Drawing.Point(223, 300);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(70, 39);
            this.Red.TabIndex = 10;
            this.Red.Text = "Red :-";
            this.Red.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Green
            // 
            this.Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Green.Location = new System.Drawing.Point(223, 364);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(70, 39);
            this.Green.TabIndex = 11;
            this.Green.Text = "Green :-";
            this.Green.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Blue
            // 
            this.Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blue.Location = new System.Drawing.Point(223, 438);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(70, 39);
            this.Blue.TabIndex = 12;
            this.Blue.Text = "Blue :-";
            this.Blue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GreenPanel
            // 
            this.GreenPanel.Controls.Add(this.GreenValue);
            this.GreenPanel.Controls.Add(this.GreenSlider);
            this.GreenPanel.Location = new System.Drawing.Point(299, 364);
            this.GreenPanel.Name = "GreenPanel";
            this.GreenPanel.Size = new System.Drawing.Size(489, 44);
            this.GreenPanel.TabIndex = 13;
            // 
            // GreenValue
            // 
            this.GreenValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GreenValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenValue.Location = new System.Drawing.Point(448, 0);
            this.GreenValue.Name = "GreenValue";
            this.GreenValue.Size = new System.Drawing.Size(41, 44);
            this.GreenValue.TabIndex = 11;
            this.GreenValue.Text = "0";
            this.GreenValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GreenSlider
            // 
            this.GreenSlider.Dock = System.Windows.Forms.DockStyle.Left;
            this.GreenSlider.Location = new System.Drawing.Point(0, 0);
            this.GreenSlider.Max = 255F;
            this.GreenSlider.Min = 0F;
            this.GreenSlider.Name = "GreenSlider";
            this.GreenSlider.Size = new System.Drawing.Size(448, 44);
            this.GreenSlider.SliderValue = 0F;
            this.GreenSlider.TabIndex = 10;
            this.GreenSlider.ValueChanged += new System.EventHandler<float>(this.GreenSlider_ValueChanged);
            // 
            // BluePanel
            // 
            this.BluePanel.Controls.Add(this.BlueValue);
            this.BluePanel.Controls.Add(this.BlueSlider);
            this.BluePanel.Location = new System.Drawing.Point(299, 435);
            this.BluePanel.Name = "BluePanel";
            this.BluePanel.Size = new System.Drawing.Size(489, 44);
            this.BluePanel.TabIndex = 12;
            // 
            // BlueValue
            // 
            this.BlueValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BlueValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueValue.Location = new System.Drawing.Point(448, 0);
            this.BlueValue.Name = "BlueValue";
            this.BlueValue.Size = new System.Drawing.Size(41, 44);
            this.BlueValue.TabIndex = 11;
            this.BlueValue.Text = "0";
            this.BlueValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlueSlider
            // 
            this.BlueSlider.Dock = System.Windows.Forms.DockStyle.Left;
            this.BlueSlider.Location = new System.Drawing.Point(0, 0);
            this.BlueSlider.Max = 255F;
            this.BlueSlider.Min = 0F;
            this.BlueSlider.Name = "BlueSlider";
            this.BlueSlider.Size = new System.Drawing.Size(448, 44);
            this.BlueSlider.SliderValue = 0F;
            this.BlueSlider.TabIndex = 10;
            this.BlueSlider.ValueChanged += new System.EventHandler<float>(this.BlueSlider_ValueChanged);
            // 
            // FramePanel
            // 
            this.FramePanel.BackColor = System.Drawing.SystemColors.ControlText;
            this.FramePanel.Controls.Add(this.AdjustPanel);
            this.FramePanel.Location = new System.Drawing.Point(16, 288);
            this.FramePanel.Name = "FramePanel";
            this.FramePanel.Size = new System.Drawing.Size(201, 176);
            this.FramePanel.TabIndex = 14;
            // 
            // CustomColorValue
            // 
            this.CustomColorValue.Location = new System.Drawing.Point(16, 492);
            this.CustomColorValue.Name = "CustomColorValue";
            this.CustomColorValue.Size = new System.Drawing.Size(200, 41);
            this.CustomColorValue.TabIndex = 15;
            this.CustomColorValue.Text = "Copy Color";
            this.CustomColorValue.UseVisualStyleBackColor = true;
            this.CustomColorValue.Click += new System.EventHandler(this.CustomColorValue_Click);
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.CustomColorValue);
            this.Controls.Add(this.FramePanel);
            this.Controls.Add(this.BluePanel);
            this.Controls.Add(this.GreenPanel);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.RedPanel);
            this.Controls.Add(this.LinePanel);
            this.Controls.Add(this.Colorpanel);
            this.Controls.Add(this.ColorValuePanel);
            this.Controls.Add(this.ColorLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ColorPicker";
            this.Text = "ColorPicker";
            this.Load += new System.EventHandler(this.ColorPicker_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ColorPickerKeyDown);
            this.Colorpanel.ResumeLayout(false);
            this.RedPanel.ResumeLayout(false);
            this.GreenPanel.ResumeLayout(false);
            this.BluePanel.ResumeLayout(false);
            this.FramePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FillPanel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Panel ColorValuePanel;
        private System.Windows.Forms.Panel Colorpanel;
        private System.Windows.Forms.Panel LinePanel;
        private System.Windows.Forms.Panel AdjustPanel;
        private System.Windows.Forms.Panel RedPanel;
        private System.Windows.Forms.Label Red;
        private System.Windows.Forms.Label Green;
        private System.Windows.Forms.Label Blue;
        private System.Windows.Forms.Panel GreenPanel;
        private System.Windows.Forms.Label GreenValue;
        private System.Windows.Forms.Panel BluePanel;
        private System.Windows.Forms.Label BlueValue;
        private VolumeSlider GreenSlider;
        private VolumeSlider BlueSlider;
        private System.Windows.Forms.Panel FramePanel;
        private VolumeSlider RedSlider;
        private System.Windows.Forms.Label RedValue;
        private System.Windows.Forms.Button CustomColorValue;
    }
}