using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractaliser {
    public class ShapeData : IData {
        public string Name { get; set; }
        public Shape Shape { get; set; }
        public bool PercentageTransform { get; set; }
        public RectangleF Region { get; set; }
        public Color BackColor { get; set; }

        public RectangleF Transform(Bitmap bmp) {
            if (PercentageTransform) {
                return new RectangleF(
                        Region.Left / 100 * bmp.Width,
                        Region.Top / 100 * bmp.Height,
                        Region.Width / 100 * bmp.Width,
                        Region.Height / 100 * bmp.Width
                    );
            }

            return this.Region;
        }

        public void Draw(Bitmap bmp, Graphics g) {
            switch (Shape) {
                case Shape.Rectangle:
                    g.FillRectangle(new SolidBrush(BackColor), Transform(bmp));
                    break;
                case Shape.Ellipse:
                    g.FillEllipse(new SolidBrush(BackColor), Transform(bmp));
                    break;
                case Shape.Triangle:
                    var tf = Transform(bmp);

                    g.FillPolygon(new SolidBrush(BackColor),
                        new PointF[] {
                            new PointF(tf.Left + tf.Width / 2, tf.Top),
                            new PointF(tf.Left, tf.Top + tf.Height),
                            new PointF(tf.Left + tf.Width, tf.Top + tf.Height)
                        });
                    break;
            }
        }
    }

    public enum Shape {
        Rectangle,
        Triangle,
        Ellipse
    }
}
