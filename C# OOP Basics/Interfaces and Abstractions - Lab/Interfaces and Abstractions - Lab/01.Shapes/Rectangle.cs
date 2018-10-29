using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public void Print()
        {
            Console.WriteLine(new String('*', this.Width));

            for (int i = 0; i < this.Height - 2; i++)
            {
                Console.WriteLine($"*{new String(' ', this.Width - 2)}*");
            }

            Console.WriteLine(new String('*', this.Width));
        }
    }
}
