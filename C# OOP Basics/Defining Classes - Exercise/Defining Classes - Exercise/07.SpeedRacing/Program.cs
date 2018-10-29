using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
   public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double consumptionForOneKm = double.Parse(carInfo[2]);

                Car car = new Car(model, fuelAmount, consumptionForOneKm);
                cars.Add(car);
            }

            string cmd = Console.ReadLine();

            while (cmd != "End")
            {
                string[] command = cmd.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string carModel = command[1];
                int amountOfKm = int.Parse(command[2]);

                var car = cars.Where(a => a.Model == carModel).FirstOrDefault();
                car.CanTheCarMoveMore(amountOfKm);
                
                cmd = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
