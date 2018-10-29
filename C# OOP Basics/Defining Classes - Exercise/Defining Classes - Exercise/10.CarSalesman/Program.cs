using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class Program
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = engineInfo[0];
                double power = double.Parse(engineInfo[1]);
                string displacement = "n/a";
                string efficiency = "n/a";

                double result = 0;

                if(engineInfo.Length == 3)
                {
                    bool isNumber = double.TryParse(engineInfo[2], out result);
                    if (isNumber)
                    {
                        displacement = engineInfo[2];
                    }
                    else
                    {
                        efficiency = engineInfo[2];
                    }
                }
                else if(engineInfo.Length == 4)
                {
                    displacement = engineInfo[2];
                    efficiency = engineInfo[3];
                }

                Engine engine = new Engine(model, power, displacement, efficiency);
                engines.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] carsInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = carsInfo[0];
                Engine engine = engines.Where(a => a.Model == carsInfo[1]).FirstOrDefault();
                double result = 0;
                string weight = "n/a";
                string color = "n/a";
                if (carsInfo.Length == 3)
                {
                    bool isNumber = double.TryParse(carsInfo[2], out result);
                    if (isNumber)
                    {
                        weight = carsInfo[2];
                    }
                    else
                    {
                        color = carsInfo[2];
                    }
                }
                else if (carsInfo.Length == 4)
                {
                    weight = carsInfo[2];
                    color = carsInfo[3];
                }

                Car car = new Car(model, engine, weight, color);
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
