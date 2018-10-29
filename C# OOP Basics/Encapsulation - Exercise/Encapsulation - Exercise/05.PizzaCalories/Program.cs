using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] currentPizza = Console.ReadLine().Split(new char[] { ' ' });
            string[] currentDough = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string flourType = currentDough[1];
            string bakingTechnique = currentDough[2];
            double weight = double.Parse(currentDough[3]);
            List<Dough> thisDough = new List<Dough>();
            List<Pizza> pizzaList = new List<Pizza>();

            try
            {
                Dough dough = new Dough(flourType, bakingTechnique, weight);
                thisDough.Add(dough);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }

            try
            {
                Pizza pizza = new Pizza(currentPizza[1], thisDough[0]);
                pizzaList.Add(pizza);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] toppings = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string toppingType = toppings[1];

                try
                {
                    Toppings topping = new Toppings(toppingType, double.Parse(toppings[2]));
                    pizzaList[0].AddTopping(topping);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }

                command = Console.ReadLine();
            }

            double toppingCalories = 0;
            foreach (var item in pizzaList[0].Toppings)
            {
                toppingCalories += double.Parse(item.CalculateCalories());
            }
            Console.WriteLine($"{pizzaList[0].Name} - {pizzaList[0].CalculateCalories(pizzaList[0].Dough, toppingCalories):f2} Calories.");

        }
    }
}
