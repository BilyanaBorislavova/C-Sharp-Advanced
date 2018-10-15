using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            HashSet<string> cars = new HashSet<string>();

            while (input != "END")
            {
                string[] carInfo = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                string direction = carInfo[0];
                string carNumber = carInfo[1];

                if(direction == "IN")
                {
                    cars.Add(carNumber);
                }
                else if(direction == "OUT")
                {
                    cars.Remove(carNumber);
                }

                input = Console.ReadLine();
            }

            if(cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
