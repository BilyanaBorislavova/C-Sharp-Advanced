using System;
using System.Collections.Generic;
using System.Linq;

namespace OpinionPoll
{
   public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> list = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = info[0];
                int age = int.Parse(info[1]);

                Person person = new Person(name, age);
                list.Add(person);
            }

            foreach (var p in list.Where(a => a.Age > 30).OrderBy(a=> a.Name))
            {
                Console.WriteLine($"{p.Name} - {p.Age}");
            }
        }
    }
}
