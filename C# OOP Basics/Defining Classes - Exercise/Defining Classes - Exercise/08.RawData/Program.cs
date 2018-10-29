using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
   public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
                string model = tokens[0];
                int speed = int.Parse(tokens[1]);
                int power = int.Parse(tokens[2]);
                int weight = int.Parse(tokens[3]);
                string type = tokens[4];
                double onePressure = double.Parse(tokens[5]);
                int oneAge = int.Parse(tokens[6]);
                double twoPressure = double.Parse(tokens[7]);
                int twoAge = int.Parse(tokens[8]);
                double threePressure = double.Parse(tokens[9]);
                int threeAge = int.Parse(tokens[10]);
                double fourPressure = double.Parse(tokens[11]);
                int fourAge = int.Parse(tokens[12]);

                Cargo cargo = new Cargo(weight, type);
                Engine engine = new Engine(speed, power);
                Tire tire = new Tire(onePressure, oneAge, twoPressure, twoAge, threePressure, threeAge, fourPressure, fourAge);
                Car car = new Car(model, engine, cargo, tire);

                if(!cars.ContainsKey(model))
                {
                    cars.Add(model, car);
                }
            }

            string cmd = Console.ReadLine();

            if(cmd == "fragile")
            {
                foreach (var car in cars.Where(a => a.Value.Cargo.CargoType == "fragile"
                    && (a.Value.Tire.TireOnePressure < 1 || a.Value.Tire.TireTwoPressure < 1 || a.Value.Tire.TireThreePressure < 1 || a.Value.Tire.TireFourPressure <1)))
                {
                    Console.WriteLine(car.Key);
                }
            }
            else if(cmd == "flamable")
            {
                foreach (var car in cars.Where(a => a.Value.Cargo.CargoType == "flamable" && a.Value.Engine.EnginePower > 250))
                {
                    Console.WriteLine(car.Key);
                }
            }
        }
    }
}
