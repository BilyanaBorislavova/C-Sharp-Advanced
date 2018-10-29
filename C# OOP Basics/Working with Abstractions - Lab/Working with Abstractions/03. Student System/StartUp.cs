using System;
using System.Collections.Generic;

namespace P03_StudentSystem
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, Student> dictionary = new Dictionary<string, Student>();

            while (true)
            {
                string[] split = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                ParseCommand(split, dictionary);
                command = Console.ReadLine();
            }
        }

        public static void Create(string name, int age, double grade, Dictionary<string, Student> dictionary)
        {
            if(!dictionary.ContainsKey(name))
            {
                dictionary.Add(name, new Student(name, age, grade));
            }
        }

        public static void Show(string name, Dictionary<string, Student> dictionary)
        {
            if (dictionary.ContainsKey(name))
            {
                string output = $"{dictionary[name].Name} is {dictionary[name].Age} years old.";

                if (dictionary[name].Grade >= 5.00)
                {
                    output += " Excellent student.";
                }
                else if (dictionary[name].Grade < 5.00 &&  dictionary[name].Grade >= 3.50)
                {
                    output += " Average student.";
                }
                else
                {
                    output += " Very nice person.";
                }

                Console.WriteLine(output);
            }
        }    

        public static void Exit()
        {
            Environment.Exit(0);
        }

        public static void ParseCommand(string[] commands, Dictionary<string, Student> dictionary)
        {
            string cmd = commands[0];

            if (cmd == "Create")
            {
                string name = commands[1];
                int age = int.Parse(commands[2]);
                double grade = double.Parse(commands[3]);

                Create(name, age, grade, dictionary);
            }
            else if (cmd == "Show")
            {
                string name = commands[1];
                Show(name, dictionary);
            }
            else if (cmd == "Exit")
            {
                Exit();
            }
        }
    }
}
