using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Google
{
   public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, Person> dictionary = new Dictionary<string, Person>();

            while (command != "End")
            {
                string[] info = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = info[0];

                if(!dictionary.ContainsKey(name))
                {
                    dictionary.Add(name, new Person(name));
                }

                if(info.Length == 5)
                {
                    string companyName = info[2];
                    string department = info[3];
                    decimal salary = decimal.Parse(info[4]);
                    Company company = new Company(companyName, department, salary);
                    dictionary[name].Company = company;
                }
                else if(info.Length == 4)
                {
                    if(command.Contains("pokemon"))
                    {
                        string pokemonName = info[2];
                        string pokemonType = info[3];
                        Pokemon pokemon = new Pokemon(pokemonName, pokemonType);
                        dictionary[name].Pokemons.Add(pokemon);
                    }
                    else if(command.Contains("parents"))
                    {
                        string parentName = info[2];
                        DateTime parentBirthday = DateTime.ParseExact(info[3], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        Parents parent = new Parents(parentName, parentBirthday);
                        dictionary[name].Parents.Add(parent);
                    }
                    else if(command.Contains("children"))
                    {
                        string childName = info[2];
                        DateTime childBirthday = DateTime.ParseExact(info[3], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        Children child = new Children(childName, childBirthday);
                        dictionary[name].Children.Add(child);
                    }
                    else if(command.Contains("car"))
                    {
                        string carModel = info[2];
                        int carSpeed = int.Parse(info[3]);
                        Car car = new Car(carModel, carSpeed);
                        dictionary[name].Car = car;
                    }
                }

                command = Console.ReadLine();
            }

            string person = Console.ReadLine();

            foreach (var item in dictionary.Where(a => a.Key == person))
            {
                Console.WriteLine(item.Key);
                Console.WriteLine("Company:");
                if(item.Value.Company != null)
                {
                    Console.WriteLine($"{item.Value.Company.CompanyName} {item.Value.Company.Department} {item.Value.Company.Salary:f2}");
                }
                Console.WriteLine("Car:");
                if (item.Value.Car != null)
                {
                    Console.WriteLine($"{item.Value.Car.Model} {item.Value.Car.Speed}");
                }
                Console.WriteLine("Pokemon:");
                if(item.Value.Pokemons.Count > 0)
                {
                    foreach (var pokemon in item.Value.Pokemons)
                    {
                        Console.WriteLine($"{pokemon.Name} {pokemon.Type}");
                    }
                }
                Console.WriteLine("Parents:");
                if(item.Value.Parents.Count > 0)
                {
                    foreach (var parent in item.Value.Parents)
                    {
                        Console.WriteLine($"{parent.Name} {parent.Birthday.Day:d2}/{parent.Birthday.Month:d2}/{parent.Birthday.Year}");
                    }
                }
                Console.WriteLine("Children:");
                if(item.Value.Children.Count > 0)
                {
                    foreach (var child in item.Value.Children)
                    {
                        Console.WriteLine($"{child.Name} {child.Birthday.Day:d2}/{child.Birthday.Month:d2}/{child.Birthday.Year}");
                    }
                }
            }
        }
    }
}
