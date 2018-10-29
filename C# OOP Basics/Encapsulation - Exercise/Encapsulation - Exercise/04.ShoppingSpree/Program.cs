using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            string[] products = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            List<Person> peopleList = new List<Person>();
            List<Product> productList = new List<Product>();

            foreach (var p in people)
            {
                string[] tokens = p.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                decimal money = decimal.Parse(tokens[1]);

                try
                {
                    Person person = new Person(name, money);
                    peopleList.Add(person);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }

            foreach (var p in products)
            {
                string[] tokens = p.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                string productName = tokens[0];
                decimal cost = decimal.Parse(tokens[1]);

                try
                {
                    Product product = new Product(productName, cost);
                    productList.Add(product);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }

            string commands = Console.ReadLine();

            while (commands != "END")
            {
                string[] split = commands.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = split[0];
                string product = split[1];

                var currentPerson = peopleList.Where(a => a.Name == name);
                var currentProduct = productList.Where(a => a.Name == product);

                foreach (var person in currentPerson)
                {
                    foreach (var prod in currentProduct)
                    {
                        person.CanAfford(person, prod);
                    }
                }

                commands = Console.ReadLine();
            }

            foreach (var person in peopleList)
            {
                person.PrintAllPeople(person);
            }
        }

    }
}
