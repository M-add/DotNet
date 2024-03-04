namespace RegionManager
{
    partial class Function
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
            this.ShapesList = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShapesList)).BeginInit();
            this.SuspendLayout();
            // 
            // ShapesList
            // 
            this.ShapesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShapesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShapesList.Location = new System.Drawing.Point(20, 14);
            this.ShapesList.Name = "ShapesList";
            this.ShapesList.Size = new System.Drawing.Size(334, 237);
            this.ShapesList.TabIndex = 0;
            this.ShapesList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShapesList_CellClick);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.BackColor = System.Drawing.Color.DarkCyan;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchButton.Location = new System.Drawing.Point(80, 316);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(200, 61);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Ok";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Function
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ShapesList);
            this.Name = "Function";
            this.Size = new System.Drawing.Size(376, 396);
            ((System.ComponentModel.ISupportInitialize)(this.ShapesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ShapesList;
        private System.Windows.Forms.Button SearchButton;
    }
}
