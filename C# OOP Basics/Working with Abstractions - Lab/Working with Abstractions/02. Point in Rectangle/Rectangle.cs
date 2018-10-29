using System;
using System.Collections.Generic;
using System.Text;

namespace PointInRectangle
{
    class Rectangle
    {
        private int topLeftX;
        private int topLeftY;
        private int bottomRightX;
        private int bottomRightY;

        public Rectangle(int topLeftX, int topLeftY, int bottomRightX, int bottomRightY)
        {
            this.TopLeftX = topLeftX;
            this.TopLeftY = TopLeftY;
            this.BottomRightX = bottomRightX;
            this.BottomRightY = bottomRightY;
        }

        public int TopLeftX
        {
            get { return topLeftX; }
            set { topLeftX = value; }
        }

        public int TopLeftY
        {
            get { return topLeftY; }
            set { topLeftY = value; }
        }

        public int BottomRightX
        {
            get { return bottomRightX; }
            set { bottomRightX = value; }
        }

        public int BottomRightY
        {
            get { return bottomRightY; }
            set { bottomRightY = value; }
        }

        public bool ContainsPoint(Point point)
        {
            return TopLeftX
        }
    }
}
