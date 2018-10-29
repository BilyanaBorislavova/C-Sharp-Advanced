using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionForOneKm;
        private double travelledDistance;

        public Car(string model, double fuelAmount, double consumptionForOneKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionForOneKm = consumptionForOneKm;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }

        public double FuelConsumptionForOneKm
        {
            get { return this.fuelConsumptionForOneKm; }
            set { this.fuelConsumptionForOneKm = value; }
        }

        public double TravelledDistance
        {
            get { return this.travelledDistance; }
            set { this.travelledDistance = value; }
        }

        public void CanTheCarMoveMore(int amountOfKm)
        {
            var fuelNeeded = amountOfKm * fuelConsumptionForOneKm;

            if(this.fuelAmount - fuelNeeded >= 0)
            {
                this.fuelAmount -= fuelNeeded;
                this.travelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
