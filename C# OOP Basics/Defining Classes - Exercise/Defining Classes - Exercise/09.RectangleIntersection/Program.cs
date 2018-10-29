using System;
using System.Collections.Generic;
using System.Linq;

namespace RectangleIntersection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int numberOfRectangles = nums[0];
            int interxectionChecks = nums[1];

            Dictionary<string, Rectangle> dict = new Dictionary<string, Rectangle>();

            for (int i = 0; i < numberOfRectangles; i++)
            {
                string[] rectangles = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string id = rectangles[0];
                double width = double.Parse(rectangles[1]);
                double height = double.Parse(rectangles[2]);
                double horizontal = double.Parse(rectangles[3]);
                double vertical = double.Parse(rectangles[4]);

                if(!dict.ContainsKey(id))
                {
                    dict.Add(id, new Rectangle(id, width, height, horizontal, vertical));
                }
                else
                {
                    dict[id] = new Rectangle(id, width, height, horizontal, vertical);
                }
            }

            for (int i = 0; i < interxectionChecks; i++)
            {
                string[] info = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Rectangle first = dict[info[0]];
                Rectangle second = dict[info[1]];
                Console.WriteLine(first.Intersection(second).ToLower());
            }
        }
    }
}
