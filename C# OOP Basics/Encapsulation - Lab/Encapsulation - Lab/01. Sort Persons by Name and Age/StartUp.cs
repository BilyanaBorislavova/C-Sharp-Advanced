using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string firstName = info[0];
                string lastName = info[1];
                int age = int.Parse(info[2]);

                Person person = new Person(firstName, lastName, age);
                people.Add(person);
            }

            foreach (var person in people.OrderBy(a => a.FirstName).ThenBy(a => a.Age))
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
