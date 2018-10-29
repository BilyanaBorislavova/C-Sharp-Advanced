using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Toppings
    {
        private string toppingType;
        private double weight;

        private string ToppingType
        {
            get => toppingType;
            set
            {
                if(value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.toppingType = value;
            }
        }

        private double Weight
        {
            get => weight;
            set
            {
                if(value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.toppingType} weight should be in the range [1..50].");
                }
                this.weight = value;
            }
        }

        public Toppings(string toppingType, double weight)
        {
            this.ToppingType = toppingType;
            this.Weight = weight;
        }

        public string CalculateCalories()
        {
            this.weight *= 2;
            if(this.toppingType.ToLower() == "meat")
            {
                this.weight *= 1.2;
            }
            else if(this.toppingType.ToLower() == "veggies")
            {
                this.weight *= 0.8;
            }
            else if(this.toppingType.ToLower() == "cheese")
            {
                this.weight *= 1.1;
            }
            else if(this.toppingType.ToLower() == "sauce")
            {
                this.weight *= 0.9;
            }
            string str = $"{this.weight:f2}";
            return str;
        }
    }
}
