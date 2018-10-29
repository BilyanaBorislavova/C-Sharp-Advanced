using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> ppl = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string firstName = str[0];
                string lastName = str[1];
                int age = int.Parse(str[2]);
                decimal salary = decimal.Parse(str[3]);

                Person person = new Person(firstName, lastName, age, salary);
                ppl.Add(person);
            }

            Team team = new Team("name");
            foreach (var p in ppl)
            {
                team.AddPlayer(p);
            }

            Console.WriteLine(team.FindSize());
        }
    }
}
