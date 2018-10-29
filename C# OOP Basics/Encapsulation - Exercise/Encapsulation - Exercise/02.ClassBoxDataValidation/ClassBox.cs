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
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        private double Height
        {
            set
            {
                if(value <= 0)
                {
                    ArgumentException("Height");
                }
                this.height = value;
            }
        }

        private double Length
        {
            set
            {
                if(value <= 0)
                {
                    ArgumentException("Length");
                }
                this.length = value;
            }
        }

        private double Width
        {
            set
            {
                if(value <= 0)
                {
                    ArgumentException("Width");
                }
                this.width = value;
            }
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

        public void ArgumentException(string name)
        {
            throw new ArgumentException($"{name} cannot be zero or negative.");
        }

    }
}
