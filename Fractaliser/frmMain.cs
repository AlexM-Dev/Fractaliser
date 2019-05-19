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
    public partial class frmMain : Form {
        private FractalRenderer Renderer = new FractalRenderer();

        public frmMain() {
            InitializeComponent();
        }
        private void BtnSelectColor_Click(object sender, EventArgs e) {
            using (var cd = new ColorDialog()) {
                cd.Color = Renderer.BackColor;

                if (cd.ShowDialog() == DialogResult.OK) {
                    Renderer.BackColor = cd.Color;
                }
            }
        }

        private void BtnNewCopyR_Click(object sender, EventArgs e) {
            using (var copy = new frmEditor()) {
                copy.EditType = EditType.CopyRegion;
                copy.Data = new RegionData() {
                    Name = $"region{cbxCopyRegion.Items.Count}",
                    PercentageTransform = true,
                };

                if (copy.ShowDialog() == DialogResult.OK) {
                    this.Renderer.CopyRegions.Add((RegionData)copy.Data);
                }
            }
        }

        private void BtnEditCopyR_Click(object sender, EventArgs e) {
            if (cbxCopyRegion.SelectedIndex > -1) {
                var index = cbxCopyRegion.SelectedIndex;
                var data = Renderer.CopyRegions[index];

                using (var copy = new frmEditor() {
                    Data = data,
                    EnableRename = false,
                    EditType = EditType.CopyRegion
                }) {
                    copy.ShowDialog();
                }
            }
        }

        private void BtnDelCopyR_Click(object sender, EventArgs e) {
            if (cbxCopyRegion.SelectedIndex > -1) {
                var index = cbxCopyRegion.SelectedIndex;

                Renderer.CopyRegions.RemoveAt(index);
            }
        }

        private void Renderer_SizeChanged(object sender, EventArgs e) {
            Renderer.Size = new Size((int)nudWidth.Value,
                                     (int)nudHeight.Value);
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            Renderer.BackColor = Color.Black;
            Renderer.Size = new Size(1024, 1024);

            cbxCopyRegion.DataSource = Renderer.CopyRegions;
            cbxCopyRegion.DisplayMember = "Name";
            cbxCopyRegion.ValueMember = "Name";

            cbxShapes.DataSource = Renderer.Shapes;
            cbxShapes.DisplayMember = "Name";
            cbxShapes.ValueMember = "Name";
        }

        private void BtnNewShape_Click(object sender, EventArgs e) {
            using (var copy = new frmEditor()) {
                copy.EditType = EditType.Shape;
                copy.Data = new ShapeData() {
                    Name = $"shape{cbxShapes.Items.Count}",
                    PercentageTransform = true,
                    BackColor = Color.White
                };

                if (copy.ShowDialog() == DialogResult.OK) {
                    this.Renderer.Shapes.Add((ShapeData)copy.Data);
                }
            }
        }

        private void BtnEditShape_Click(object sender, EventArgs e) {
            if (cbxShapes.SelectedIndex > -1) {
                var index = cbxShapes.SelectedIndex;
                var data = Renderer.Shapes[index];

                using (var copy = new frmEditor() {
                    Data = data,
                    EnableRename = false,
                    EditType = EditType.Shape
                }) {
                    copy.ShowDialog();
                }
            }
        }

        private void BtnDelShape_Click(object sender, EventArgs e) {
            if (cbxShapes.SelectedIndex > -1) {
                var index = cbxShapes.SelectedIndex;

                Renderer.Shapes.RemoveAt(index);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e) {
            var result = MessageBox.Show("Are you sure you wish to " +
                "clear the render? All images will be lost.",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                Renderer.Previous.Dispose();
                Renderer.Current.Dispose();
                Renderer.Previous = null;
                Renderer.Current = null;

                picFractal.Image.Dispose();
                picFractal.Image = null;
            }
        }

        private void BtnRender_Click(object sender, EventArgs e) {
            Renderer.Render();

            picFractal.Image = Renderer.Current;
        }
    }
}