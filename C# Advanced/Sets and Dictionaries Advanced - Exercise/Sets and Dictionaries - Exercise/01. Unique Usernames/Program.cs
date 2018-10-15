using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> uniqueUsernames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string username = Console.ReadLine();

                uniqueUsernames.Add(username);
            }

            foreach (var name in uniqueUsernames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
