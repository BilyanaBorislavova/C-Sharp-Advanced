using System;

namespace Vehicles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] truckInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if(info[0] == "Drive")
                {
                    double distance = double.Parse(info[2]);

                    if (info[1] == "Car")
                    {
                        car.Drive(distance);
                    }
                    else if(info[1] == "Truck")
                    {
                        truck.Drive(distance);
                    }
                }
                else if(info[0] == "Refuel")
                {
                    double litres = double.Parse(info[2]);

                    if (info[1] == "Car")
                    {
                        car.Refuel(litres);
                    }
                    else if (info[1] == "Truck")
                    {
                        truck.Refuel(litres);
                    }
                }
            }

            Console.WriteLine($"Car: {car.fuelConsumption:f2}");
            Console.WriteLine($"Truck: {truck.fuelConsumption:f2}");
        }
    }
}
