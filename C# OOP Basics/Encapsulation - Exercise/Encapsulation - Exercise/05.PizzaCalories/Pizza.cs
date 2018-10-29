using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
     class Pizza
    {
        private string name;
        private Dough dough;
        private List<Toppings> toppings;

        public string Name
        {
            get => name;
            set
            {
                if(value == "" || value == " " || value == null && value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        public Dough Dough
        {
            get => dough;
            set { this.dough = value; }
        }

        public List<Toppings> Toppings
        {
            get => toppings;
            set
            {
                this.toppings = value;
            }
        }

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.Toppings = new List<Toppings>();
        }

        public void AddTopping(Toppings topping)
        {
            if (this.Toppings.Count > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            this.Toppings.Add(topping);
        }

        public double CalculateCalories(Dough dough, double toppings)
        {
            return double.Parse(dough.CalculateCalories()) + toppings;
        }


    }
}
