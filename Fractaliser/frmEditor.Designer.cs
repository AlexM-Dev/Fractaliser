namespace Fractaliser {
    partial class frmEditor {
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.lblY = new System.Windows.Forms.Label();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.lblWidth = new System.Windows.Forms.Label();
            this.btnOkay = new System.Windows.Forms.Button();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.chkTransform = new System.Windows.Forms.CheckBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblShape = new System.Windows.Forms.Label();
            this.cbxShape = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Location = new System.Drawing.Point(20, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(277, 23);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "object0";
            // 
            // lblX
            // 
            this.lblX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblX.Location = new System.Drawing.Point(17, 67);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 23);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "X:";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudX
            // 
            this.nudX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudX.DecimalPlaces = 3;
            this.nudX.Location = new System.Drawing.Point(40, 67);
            this.nudX.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(97, 23);
            this.nudX.TabIndex = 3;
            this.nudX.ValueChanged += new System.EventHandler(this.region_ValueChanged);
            // 
            // nudY
            // 
            this.nudY.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudY.DecimalPlaces = 3;
            this.nudY.Location = new System.Drawing.Point(40, 96);
            this.nudY.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(97, 23);
            this.nudY.TabIndex = 5;
            this.nudY.ValueChanged += new System.EventHandler(this.region_ValueChanged);
            // 
            // lblY
            // 
            this.lblY.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblY.Location = new System.Drawing.Point(17, 96);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 23);
            this.lblY.TabIndex = 4;
            this.lblY.Text = "Y:";
            this.lblY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudHeight
            // 
            this.nudHeight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudHeight.DecimalPlaces = 3;
            this.nudHeight.Location = new System.Drawing.Point(200, 96);
            this.nudHeight.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(97, 23);
            this.nudHeight.TabIndex = 9;
            this.nudHeight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudHeight.ValueChanged += new System.EventHandler(this.region_ValueChanged);
            // 
            // lblHeight
            // 
            this.lblHeight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeight.Location = new System.Drawing.Point(146, 96);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(48, 23);
            this.lblHeight.TabIndex = 8;
            this.lblHeight.Text = "Height:";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudWidth
            // 
            this.nudWidth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudWidth.DecimalPlaces = 3;
            this.nudWidth.Location = new System.Drawing.Point(200, 67);
            this.nudWidth.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(97, 23);
            this.nudWidth.TabIndex = 7;
            this.nudWidth.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudWidth.ValueChanged += new System.EventHandler(this.region_ValueChanged);
            // 
            // lblWidth
            // 
            this.lblWidth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWidth.Location = new System.Drawing.Point(143, 67);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(51, 23);
            this.lblWidth.TabIndex = 6;
            this.lblWidth.Text = "Width:";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOkay
            // 
            this.btnOkay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOkay.Location = new System.Drawing.Point(208, 452);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(89, 27);
            this.btnOkay.TabIndex = 10;
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.BtnOkay_Click);
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(57, 245);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(200, 200);
            this.picPreview.TabIndex = 12;
            this.picPreview.TabStop = false;
            // 
            // chkTransform
            // 
            this.chkTransform.AutoSize = true;
            this.chkTransform.Checked = true;
            this.chkTransform.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTransform.Location = new System.Drawing.Point(20, 125);
            this.chkTransform.Name = "chkTransform";
            this.chkTransform.Size = new System.Drawing.Size(142, 19);
            this.chkTransform.TabIndex = 13;
            this.chkTransform.Text = "Percentage Transform";
            this.chkTransform.UseVisualStyleBackColor = true;
            this.chkTransform.CheckedChanged += new System.EventHandler(this.ChkTransform_CheckedChanged);
            // 
            // btnColor
            // 
            this.btnColor.Enabled = false;
            this.btnColor.Location = new System.Drawing.Point(20, 206);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(108, 27);
            this.btnColor.TabIndex = 14;
            this.btnColor.Text = "Select Color...";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // lblShape
            // 
            this.lblShape.AutoSize = true;
            this.lblShape.Enabled = false;
            this.lblShape.Location = new System.Drawing.Point(17, 159);
            this.lblShape.Name = "lblShape";
            this.lblShape.Size = new System.Drawing.Size(42, 15);
            this.lblShape.TabIndex = 15;
            this.lblShape.Text = "Shape:";
            // 
            // cbxShape
            // 
            this.cbxShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxShape.Enabled = false;
            this.cbxShape.FormattingEnabled = true;
            this.cbxShape.Location = new System.Drawing.Point(20, 177);
            this.cbxShape.Name = "cbxShape";
            this.cbxShape.Size = new System.Drawing.Size(277, 23);
            this.cbxShape.TabIndex = 16;
            this.cbxShape.SelectedIndexChanged += new System.EventHandler(this.CbxShape_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(113, 452);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 27);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(177, 218);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(120, 15);
            this.lblInfo.TabIndex = 17;
            this.lblInfo.Text = "* preview not to scale";
            // 
            // frmEditor
            // 
            this.AcceptButton = this.btnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(314, 491);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.cbxShape);
            this.Controls.Add(this.lblShape);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.chkTransform);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.nudX);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(330, 530);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(330, 530);
            this.Name = "frmEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Object Editor";
            this.Load += new System.EventHandler(this.FrmCopyR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.CheckBox chkTransform;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label lblShape;
        private System.Windows.Forms.ComboBox cbxShape;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblInfo;
    }
}