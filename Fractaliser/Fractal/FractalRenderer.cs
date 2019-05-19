using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractaliser {
    // Inspired by https://www.youtube.com/watch?v=b-Fa6HtvGtQ
    // Written by Alex M., 2019.
    class FractalRenderer {
        public Color BackColor { get; set; } = Color.Black;
        public Size Size { get; set; }
        public Bitmap Previous { get; set; }
        public Bitmap Current { get; set; }
        public BindingList<RegionData> CopyRegions { get; } =
            new BindingList<RegionData>();

        public BindingList<ShapeData> Shapes { get; } =
            new BindingList<ShapeData>();

        public void Render() {
            var bmp = new Bitmap(Size.Width, Size.Height);
            var g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(this.BackColor), 
                new Rectangle(0, 0, bmp.Width, bmp.Height));

            this.Previous = this.Current;

            if (this.Previous != null) {
                foreach (var copy in this.CopyRegions) {
                    var tf = copy.Transform(bmp);

                    var res = ResizeImage(this.Previous,
                        (int)tf.Width, (int)tf.Height);

                    g.DrawImage(res, tf.Location);
                }
            }

            foreach (var shapeData in this.Shapes) {
                var tf = shapeData.Transform(bmp);

                shapeData.Draw(bmp, g);
            }

            this.Current = bmp;
        }

        // https://stackoverflow.com/questions/1922040/how-to-resize-an-image-c-sharp
        private static Bitmap ResizeImage(Image image, int width, int height) {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution,
                image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage)) {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode =
                    InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes()) {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width,
                        image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
