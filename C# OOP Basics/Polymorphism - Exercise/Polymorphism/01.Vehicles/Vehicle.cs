using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
     public class Vehicle : IVehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
        }

        public double fuelQuantity { get; set; }
        public double fuelConsumption { get; set; }

        public virtual void Drive(double disance)
        {
            if(disance * this.fuelConsumption >= this.fuelQuantity)
            {
                this.fuelQuantity -= disance * this.fuelConsumption;
                Console.WriteLine($"{GetType().Name} travelled {disance} km");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
        }

        public virtual void Refuel(double liters)
        {
            this.fuelQuantity += liters;
        }
    }
}
