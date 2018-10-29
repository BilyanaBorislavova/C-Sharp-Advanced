using System;
using System.Collections.Generic;

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
                decimal salary = decimal.Parse(info[3]);

                Person person = new Person(firstName, lastName, age, salary);
                people.Add(person);
            }

            decimal percentage = decimal.Parse(Console.ReadLine());

            foreach (var person in people)
            {
                person.IncreaseSalary(percentage);
                Console.WriteLine(person.ToString());
            }
        }
    }
}
