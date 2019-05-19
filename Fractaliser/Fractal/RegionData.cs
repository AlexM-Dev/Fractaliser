using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractaliser {
    public class RegionData : IData {
        public string Name { get; set; }
        public bool PercentageTransform { get; set; }        
        public RectangleF Region { get; set; }

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
    }
}
