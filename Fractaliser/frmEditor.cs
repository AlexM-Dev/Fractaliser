using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractaliser {
    public partial class frmEditor : Form {
        private bool doUpdate = false;

        private Bitmap bmp;
        private Graphics g;

        public bool EnableRename { get; set; } = true;
        public EditType EditType { get; set; }
        public IData Data { get; set; }

        private void BtnOkay_Click(object sender, EventArgs e) {
            var region = new RectangleF(
                 (float)nudX.Value,
                 (float)nudY.Value,
                 (float)nudWidth.Value,
                 (float)nudHeight.Value);

            Data.Region = region;

            if (EnableRename) {
                Data.Name = txtName.Text;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmCopyR_Load(object sender, EventArgs e) {
            cbxShape.DataSource = Enum.GetValues(typeof(Shape));
            txtName.Enabled = EnableRename;
            btnCancel.Enabled = EnableRename;

            txtName.Text = Data.Name;
            chkTransform.Checked = Data.PercentageTransform;

            nudX.Value = (decimal)Data.Region.Left;
            nudY.Value = (decimal)Data.Region.Top;
            nudWidth.Value = (decimal)Data.Region.Width;
            nudHeight.Value = (decimal)Data.Region.Height;

            if (this.EditType == EditType.Shape) {
                lblShape.Enabled = true;
                cbxShape.Enabled = true;
                btnColor.Enabled = true;
            }

            this.bmp = new Bitmap(200, 200);

            this.g = Graphics.FromImage(this.bmp);
            this.g.FillRectangle(Brushes.Black, 0, 0, 200, 200);

            doUpdate = true;
            picPreview.Image = this.bmp;
            updateBmp();
        }

        private void region_ValueChanged(object sender, EventArgs e) {
            if (doUpdate)
                updateBmp();
        }

        private void updateBmp() {
            g.FillRectangle(Brushes.Black, 0, 0, 200, 200);

            Data.Region = new RectangleF(
                (float)nudX.Value,
                (float)nudY.Value,
                (float)nudWidth.Value,
                (float)nudHeight.Value);

            var tf = Data.Transform(bmp);

            switch (EditType) {
                case EditType.CopyRegion:
                    g.FillRectangle(Brushes.Red, tf);
                    break;
                case EditType.Shape:
                    ((ShapeData)Data).Draw(bmp, g);
                    break;
            }

            picPreview.Refresh();
        }


        public frmEditor() {
            InitializeComponent();
        }

        private void ChkTransform_CheckedChanged(object sender, EventArgs e) {
            Data.PercentageTransform = chkTransform.Checked;

            if (doUpdate)
                updateBmp();
        }

        private void CbxShape_SelectedIndexChanged(object sender, EventArgs e) {
            if (EditType == EditType.Shape) {
                ((ShapeData)Data).Shape = (Shape)cbxShape.SelectedItem;
                if (doUpdate)
                    updateBmp();
            }
        }

        private void BtnColor_Click(object sender, EventArgs e) {
            using (var cd = new ColorDialog()) {
                cd.Color = ((ShapeData)Data).BackColor;

                if (cd.ShowDialog() == DialogResult.OK) {
                    ((ShapeData)Data).BackColor = cd.Color;
                    updateBmp();
                }
            }
        }
    }

    public enum EditType {
        CopyRegion,
        Shape
    }
}
