using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    class Person
    {
        private string name;
        private decimal money;
        private List<string> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.Products = new List<string>();
        }

        public List<string> Products
        {
            get => products;
            set { this.products = value; }
        }

        public string Name
        {
            get => name;
            set
            {
                if(value == "" || value == null || value == " ")
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Money
        {
            get => money;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public void AddProduct(string product)
        {
            this.products.Add(product);
        }

        public void CanAfford(Person person, Product product)
        {
            if (person.Money >= product.Cost)
            {
                Console.WriteLine($"{person.Name} bought {product.Name}");
                person.Money -= product.Cost;
                person.AddProduct(product.Name);
            }
            else
            {
                Console.WriteLine($"{person.Name} can't afford {product.Name}");
            }
        }

        public void PrintAllPeople(Person person)
        {
            if (person.Products.Count > 0)
            {
                Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products)}");
            }
            else
            {
                Console.WriteLine($"{person.Name} - Nothing bought");
            }
        }

    }
}
