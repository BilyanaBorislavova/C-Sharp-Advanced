using System;

namespace ClassBox
{
    public class Program
    {
       public static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                ClassBox classBox = new ClassBox(length, width, height);
                classBox.SurfaceArea(length, width, height);
                classBox.LateralSurfaceArea(length, width, height);
                classBox.Volume(length, width, height);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
