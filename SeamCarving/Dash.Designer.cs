namespace SeamCarving
{
    partial class Dash
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
            this.pbox_original = new System.Windows.Forms.PictureBox();
            this.btn_selectImage = new System.Windows.Forms.Button();
            this.btn_startEdge = new System.Windows.Forms.Button();
            this.btn_perform = new System.Windows.Forms.Button();
            this.num_height = new System.Windows.Forms.NumericUpDown();
            this.num_width = new System.Windows.Forms.NumericUpDown();
            this.lbl_width = new System.Windows.Forms.Label();
            this.lbl_height = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_width)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_original
            // 
            this.pbox_original.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbox_original.Location = new System.Drawing.Point(14, 121);
            this.pbox_original.Name = "pbox_original";
            this.pbox_original.Size = new System.Drawing.Size(751, 472);
            this.pbox_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_original.TabIndex = 0;
            this.pbox_original.TabStop = false;
            // 
            // btn_selectImage
            // 
            this.btn_selectImage.BackColor = System.Drawing.Color.Blue;
            this.btn_selectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selectImage.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectImage.ForeColor = System.Drawing.Color.White;
            this.btn_selectImage.Location = new System.Drawing.Point(14, 3);
            this.btn_selectImage.Name = "btn_selectImage";
            this.btn_selectImage.Size = new System.Drawing.Size(196, 54);
            this.btn_selectImage.TabIndex = 1;
            this.btn_selectImage.Text = "Choose image";
            this.btn_selectImage.UseVisualStyleBackColor = false;
            this.btn_selectImage.Click += new System.EventHandler(this.btn_selectImage_Click);
            // 
            // btn_startEdge
            // 
            this.btn_startEdge.BackColor = System.Drawing.Color.DimGray;
            this.btn_startEdge.Enabled = false;
            this.btn_startEdge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_startEdge.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startEdge.ForeColor = System.Drawing.Color.White;
            this.btn_startEdge.Location = new System.Drawing.Point(14, 63);
            this.btn_startEdge.Name = "btn_startEdge";
            this.btn_startEdge.Size = new System.Drawing.Size(196, 51);
            this.btn_startEdge.TabIndex = 2;
            this.btn_startEdge.Text = "Show edges";
            this.btn_startEdge.UseVisualStyleBackColor = false;
            this.btn_startEdge.Click += new System.EventHandler(this.btn_startEdge_Click);
            // 
            // btn_perform
            // 
            this.btn_perform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_perform.BackColor = System.Drawing.Color.Orange;
            this.btn_perform.Enabled = false;
            this.btn_perform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_perform.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_perform.ForeColor = System.Drawing.Color.White;
            this.btn_perform.Location = new System.Drawing.Point(569, 3);
            this.btn_perform.Name = "btn_perform";
            this.btn_perform.Size = new System.Drawing.Size(196, 55);
            this.btn_perform.TabIndex = 5;
            this.btn_perform.Text = "Resize";
            this.btn_perform.UseVisualStyleBackColor = false;
            this.btn_perform.Click += new System.EventHandler(this.btn_perform_Click);
            // 
            // num_height
            // 
            this.num_height.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.num_height.Enabled = false;
            this.num_height.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_height.Location = new System.Drawing.Point(321, 71);
            this.num_height.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.num_height.Name = "num_height";
            this.num_height.Size = new System.Drawing.Size(242, 33);
            this.num_height.TabIndex = 6;
            // 
            // num_width
            // 
            this.num_width.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.num_width.BackColor = System.Drawing.Color.White;
            this.num_width.Enabled = false;
            this.num_width.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_width.Location = new System.Drawing.Point(321, 14);
            this.num_width.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.num_width.Name = "num_width";
            this.num_width.Size = new System.Drawing.Size(242, 33);
            this.num_width.TabIndex = 7;
            // 
            // lbl_width
            // 
            this.lbl_width.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_width.AutoSize = true;
            this.lbl_width.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_width.Location = new System.Drawing.Point(216, 14);
            this.lbl_width.Name = "lbl_width";
            this.lbl_width.Size = new System.Drawing.Size(99, 29);
            this.lbl_width.TabIndex = 8;
            this.lbl_width.Text = "Width:";
            // 
            // lbl_height
            // 
            this.lbl_height.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_height.AutoSize = true;
            this.lbl_height.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_height.Location = new System.Drawing.Point(216, 71);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(108, 29);
            this.lbl_height.TabIndex = 9;
            this.lbl_height.Text = "Height:";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.Green;
            this.btn_save.Enabled = false;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(569, 60);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(196, 54);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 605);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_width);
            this.Controls.Add(this.num_width);
            this.Controls.Add(this.num_height);
            this.Controls.Add(this.btn_perform);
            this.Controls.Add(this.pbox_original);
            this.Controls.Add(this.btn_startEdge);
            this.Controls.Add(this.btn_selectImage);
            this.Controls.Add(this.lbl_height);
            this.MinimumSize = new System.Drawing.Size(793, 644);
            this.Name = "Dash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dash";
            this.Load += new System.EventHandler(this.Dash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_width)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_original;
        private System.Windows.Forms.Button btn_selectImage;
        private System.Windows.Forms.Button btn_startEdge;
        private System.Windows.Forms.Button btn_perform;
        private System.Windows.Forms.NumericUpDown num_height;
        private System.Windows.Forms.NumericUpDown num_width;
        private System.Windows.Forms.Label lbl_width;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.Button btn_save;
    }
}

