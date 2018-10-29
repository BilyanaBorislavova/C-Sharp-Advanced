using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleIntersection
{
    public class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double horizontal;
        private double vertical;

        public Rectangle(string id, double width, double height, double horizontal, double vertical)
        {
            this.Id = id;
            this.Width = width;
            this.Height = height;
            this.Horizontal = horizontal;
            this.Vertical = vertical;
        }

        public double Vertical
        {
            get { return vertical; }
            set { vertical = value; }
        }


        public double Horizontal
        {
            get { return horizontal; }
            set { horizontal = value; }
        }


        public double Height
        {
            get { return height; }
            set { height = value; }
        }


        public double Width
        {
            get { return width; }
            set { width = value; }
        }


        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Intersection(Rectangle rectangle)
        {
            if (this.horizontal + this.Width < rectangle.Horizontal
            || rectangle.Horizontal + rectangle.Width < this.horizontal
            || this.vertical + this.Height < rectangle.Vertical
            || rectangle.Vertical + rectangle.Height < this.vertical)
            {
                return "false";
            }
            return "true";
        }

    }
}
