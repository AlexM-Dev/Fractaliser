namespace Fractaliser {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.picFractal = new System.Windows.Forms.PictureBox();
            this.cbxCopyRegion = new System.Windows.Forms.ComboBox();
            this.gbpCopyRegions = new System.Windows.Forms.GroupBox();
            this.btnDelCopyR = new System.Windows.Forms.Button();
            this.btnEditCopyR = new System.Windows.Forms.Button();
            this.btnNewCopyR = new System.Windows.Forms.Button();
            this.gpbImage = new System.Windows.Forms.GroupBox();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.lblWidth = new System.Windows.Forms.Label();
            this.btnSelectColor = new System.Windows.Forms.Button();
            this.lblBackgroundColor = new System.Windows.Forms.Label();
            this.chkPreview = new System.Windows.Forms.CheckBox();
            this.gpbShapes = new System.Windows.Forms.GroupBox();
            this.btnDelShape = new System.Windows.Forms.Button();
            this.btnEditShape = new System.Windows.Forms.Button();
            this.btnNewShape = new System.Windows.Forms.Button();
            this.cbxShapes = new System.Windows.Forms.ComboBox();
            this.btnRender = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFractal)).BeginInit();
            this.gbpCopyRegions.SuspendLayout();
            this.gpbImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            this.gpbShapes.SuspendLayout();
            this.SuspendLayout();
            // 
            // picFractal
            // 
            this.picFractal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picFractal.Location = new System.Drawing.Point(14, 15);
            this.picFractal.Name = "picFractal";
            this.picFractal.Size = new System.Drawing.Size(469, 486);
            this.picFractal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFractal.TabIndex = 0;
            this.picFractal.TabStop = false;
            // 
            // cbxCopyRegion
            // 
            this.cbxCopyRegion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxCopyRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCopyRegion.FormattingEnabled = true;
            this.cbxCopyRegion.Location = new System.Drawing.Point(22, 46);
            this.cbxCopyRegion.Name = "cbxCopyRegion";
            this.cbxCopyRegion.Size = new System.Drawing.Size(310, 23);
            this.cbxCopyRegion.TabIndex = 2;
            // 
            // gbpCopyRegions
            // 
            this.gbpCopyRegions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbpCopyRegions.Controls.Add(this.btnDelCopyR);
            this.gbpCopyRegions.Controls.Add(this.btnEditCopyR);
            this.gbpCopyRegions.Controls.Add(this.btnNewCopyR);
            this.gbpCopyRegions.Controls.Add(this.cbxCopyRegion);
            this.gbpCopyRegions.Location = new System.Drawing.Point(491, 164);
            this.gbpCopyRegions.Name = "gbpCopyRegions";
            this.gbpCopyRegions.Size = new System.Drawing.Size(355, 143);
            this.gbpCopyRegions.TabIndex = 3;
            this.gbpCopyRegions.TabStop = false;
            this.gbpCopyRegions.Text = "Copy Regions";
            // 
            // btnDelCopyR
            // 
            this.btnDelCopyR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelCopyR.Location = new System.Drawing.Point(245, 77);
            this.btnDelCopyR.Name = "btnDelCopyR";
            this.btnDelCopyR.Size = new System.Drawing.Size(87, 27);
            this.btnDelCopyR.TabIndex = 5;
            this.btnDelCopyR.Text = "Delete";
            this.btnDelCopyR.UseVisualStyleBackColor = true;
            this.btnDelCopyR.Click += new System.EventHandler(this.BtnDelCopyR_Click);
            // 
            // btnEditCopyR
            // 
            this.btnEditCopyR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditCopyR.Location = new System.Drawing.Point(134, 77);
            this.btnEditCopyR.Name = "btnEditCopyR";
            this.btnEditCopyR.Size = new System.Drawing.Size(87, 27);
            this.btnEditCopyR.TabIndex = 4;
            this.btnEditCopyR.Text = "Edit";
            this.btnEditCopyR.UseVisualStyleBackColor = true;
            this.btnEditCopyR.Click += new System.EventHandler(this.BtnEditCopyR_Click);
            // 
            // btnNewCopyR
            // 
            this.btnNewCopyR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewCopyR.Location = new System.Drawing.Point(22, 77);
            this.btnNewCopyR.Name = "btnNewCopyR";
            this.btnNewCopyR.Size = new System.Drawing.Size(87, 27);
            this.btnNewCopyR.TabIndex = 3;
            this.btnNewCopyR.Text = "New";
            this.btnNewCopyR.UseVisualStyleBackColor = true;
            this.btnNewCopyR.Click += new System.EventHandler(this.BtnNewCopyR_Click);
            // 
            // gpbImage
            // 
            this.gpbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbImage.Controls.Add(this.nudHeight);
            this.gpbImage.Controls.Add(this.lblHeight);
            this.gpbImage.Controls.Add(this.nudWidth);
            this.gpbImage.Controls.Add(this.lblWidth);
            this.gpbImage.Controls.Add(this.btnSelectColor);
            this.gpbImage.Controls.Add(this.lblBackgroundColor);
            this.gpbImage.Location = new System.Drawing.Point(491, 15);
            this.gpbImage.Name = "gpbImage";
            this.gpbImage.Size = new System.Drawing.Size(355, 143);
            this.gpbImage.TabIndex = 6;
            this.gpbImage.TabStop = false;
            this.gpbImage.Text = "Image";
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(246, 55);
            this.nudHeight.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(77, 23);
            this.nudHeight.TabIndex = 5;
            this.nudHeight.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudHeight.ValueChanged += new System.EventHandler(this.Renderer_SizeChanged);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(243, 36);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(46, 15);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Height:";
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(163, 55);
            this.nudWidth.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(77, 23);
            this.nudWidth.TabIndex = 3;
            this.nudWidth.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudWidth.ValueChanged += new System.EventHandler(this.Renderer_SizeChanged);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(160, 36);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(42, 15);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width:";
            // 
            // btnSelectColor
            // 
            this.btnSelectColor.Location = new System.Drawing.Point(34, 55);
            this.btnSelectColor.Name = "btnSelectColor";
            this.btnSelectColor.Size = new System.Drawing.Size(123, 23);
            this.btnSelectColor.TabIndex = 1;
            this.btnSelectColor.Text = "...";
            this.btnSelectColor.UseVisualStyleBackColor = true;
            this.btnSelectColor.Click += new System.EventHandler(this.BtnSelectColor_Click);
            // 
            // lblBackgroundColor
            // 
            this.lblBackgroundColor.AutoSize = true;
            this.lblBackgroundColor.Location = new System.Drawing.Point(31, 36);
            this.lblBackgroundColor.Name = "lblBackgroundColor";
            this.lblBackgroundColor.Size = new System.Drawing.Size(106, 15);
            this.lblBackgroundColor.TabIndex = 0;
            this.lblBackgroundColor.Text = "Background Color:";
            // 
            // chkPreview
            // 
            this.chkPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPreview.AutoSize = true;
            this.chkPreview.Checked = true;
            this.chkPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPreview.Location = new System.Drawing.Point(491, 482);
            this.chkPreview.Name = "chkPreview";
            this.chkPreview.Size = new System.Drawing.Size(103, 19);
            this.chkPreview.TabIndex = 7;
            this.chkPreview.Text = "Preview Image";
            this.chkPreview.UseVisualStyleBackColor = true;
            // 
            // gpbShapes
            // 
            this.gpbShapes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbShapes.Controls.Add(this.btnDelShape);
            this.gpbShapes.Controls.Add(this.btnEditShape);
            this.gpbShapes.Controls.Add(this.btnNewShape);
            this.gpbShapes.Controls.Add(this.cbxShapes);
            this.gpbShapes.Location = new System.Drawing.Point(491, 313);
            this.gpbShapes.Name = "gpbShapes";
            this.gpbShapes.Size = new System.Drawing.Size(355, 143);
            this.gpbShapes.TabIndex = 6;
            this.gpbShapes.TabStop = false;
            this.gpbShapes.Text = "Shapes";
            // 
            // btnDelShape
            // 
            this.btnDelShape.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelShape.Location = new System.Drawing.Point(245, 77);
            this.btnDelShape.Name = "btnDelShape";
            this.btnDelShape.Size = new System.Drawing.Size(87, 27);
            this.btnDelShape.TabIndex = 5;
            this.btnDelShape.Text = "Delete";
            this.btnDelShape.UseVisualStyleBackColor = true;
            this.btnDelShape.Click += new System.EventHandler(this.BtnDelShape_Click);
            // 
            // btnEditShape
            // 
            this.btnEditShape.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditShape.Location = new System.Drawing.Point(134, 77);
            this.btnEditShape.Name = "btnEditShape";
            this.btnEditShape.Size = new System.Drawing.Size(87, 27);
            this.btnEditShape.TabIndex = 4;
            this.btnEditShape.Text = "Edit";
            this.btnEditShape.UseVisualStyleBackColor = true;
            this.btnEditShape.Click += new System.EventHandler(this.BtnEditShape_Click);
            // 
            // btnNewShape
            // 
            this.btnNewShape.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewShape.Location = new System.Drawing.Point(22, 77);
            this.btnNewShape.Name = "btnNewShape";
            this.btnNewShape.Size = new System.Drawing.Size(87, 27);
            this.btnNewShape.TabIndex = 3;
            this.btnNewShape.Text = "New";
            this.btnNewShape.UseVisualStyleBackColor = true;
            this.btnNewShape.Click += new System.EventHandler(this.BtnNewShape_Click);
            // 
            // cbxShapes
            // 
            this.cbxShapes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxShapes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxShapes.FormattingEnabled = true;
            this.cbxShapes.Location = new System.Drawing.Point(22, 46);
            this.cbxShapes.Name = "cbxShapes";
            this.cbxShapes.Size = new System.Drawing.Size(310, 23);
            this.cbxShapes.TabIndex = 2;
            // 
            // btnRender
            // 
            this.btnRender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRender.Location = new System.Drawing.Point(759, 474);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(87, 27);
            this.btnRender.TabIndex = 6;
            this.btnRender.Text = "Render";
            this.btnRender.UseVisualStyleBackColor = true;
            this.btnRender.Click += new System.EventHandler(this.BtnRender_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(666, 474);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 27);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 515);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRender);
            this.Controls.Add(this.gpbShapes);
            this.Controls.Add(this.chkPreview);
            this.Controls.Add(this.gpbImage);
            this.Controls.Add(this.gbpCopyRegions);
            this.Controls.Add(this.picFractal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmMain";
            this.Text = "Fractaliser";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFractal)).EndInit();
            this.gbpCopyRegions.ResumeLayout(false);
            this.gpbImage.ResumeLayout(false);
            this.gpbImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            this.gpbShapes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFractal;
        private System.Windows.Forms.ComboBox cbxCopyRegion;
        private System.Windows.Forms.GroupBox gbpCopyRegions;
        private System.Windows.Forms.Button btnNewCopyR;
        private System.Windows.Forms.Button btnEditCopyR;
        private System.Windows.Forms.Button btnDelCopyR;
        private System.Windows.Forms.GroupBox gpbImage;
        private System.Windows.Forms.Label lblBackgroundColor;
        private System.Windows.Forms.Button btnSelectColor;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.CheckBox chkPreview;
        private System.Windows.Forms.GroupBox gpbShapes;
        private System.Windows.Forms.Button btnDelShape;
        private System.Windows.Forms.Button btnEditShape;
        private System.Windows.Forms.Button btnNewShape;
        private System.Windows.Forms.ComboBox cbxShapes;
        private System.Windows.Forms.Button btnRender;
        private System.Windows.Forms.Button btnClear;
    }
}

