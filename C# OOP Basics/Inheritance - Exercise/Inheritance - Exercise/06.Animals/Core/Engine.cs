using Animals.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Core
{
    public class Engine
    {
        public void Run()
        {
            string command = Console.ReadLine();

            while (command != "Beast!")
            {
                string animal = command;
                string[] info = Console.ReadLine().Split();

                try
                {
                    if (animal == "Cat")
                    {
                        Cat cat = new Cat(info[0], int.Parse(info[1]), info[2]);
                        Console.WriteLine(cat.ToString());
                    }
                    else if (animal == "Dog")
                    {
                        Dog dog = new Dog(info[0], int.Parse(info[1]), info[2]);
                        Console.WriteLine(dog.ToString());
                    }
                    else if (animal == "Frog")
                    {
                        Frog frog = new Frog(info[0], int.Parse(info[1]), info[2]);
                        Console.WriteLine(frog.ToString());
                    }
                    else if (animal == "Kitten")
                    {

                            Kitten kittens = new Kitten(info[0], int.Parse(info[1]));
                            Console.WriteLine(kittens.ToString());

                    }
                    else if (animal == "Tomcat")
                    {

                            Tomcat tomcat = new Tomcat(info[0], int.Parse(info[1]));
                            Console.WriteLine(tomcat.ToString());

                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                command = Console.ReadLine();
            }
        }
    }
}
