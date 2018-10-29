using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBox
{
    public class ClassBox
    {
        private double length;
        private double width;
        private double height;

        public ClassBox(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public void SurfaceArea(double length, double width, double height)
        {
            //2lw + 2lh + 2wh
            Console.WriteLine($"Surface Area - {2 * length * width + 2 * length * height + 2 * width * height:f2}");
        }

        public void LateralSurfaceArea(double length, double width, double height)
        {
            //2lh + 2wh
            Console.WriteLine($"Lateral Surface Area - {2 * length * height + 2 * width * height:f2}");
        }

        public void Volume(double length, double width, double height)
        {
            Console.WriteLine($"Volume - {length * width * height:f2}");
        }
    }
}
