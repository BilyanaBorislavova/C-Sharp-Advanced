using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _04._Treasure_Map
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Regex regex = new Regex(@"!([^#!]*)(?<one>[a-zA-Z]{4})([^#!]*)(?<two>[0-9]{3}\-([0-9]{4}|[0-9]{6}))([^#!]*)#|#([^#!]*)(?<three>[a-zA-Z]{4})([^#!]*)(?<four>[0-9]{3}\-([0-9]{4}|[0-9]{6}))([^#!]*)!");

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                MatchCollection matches = regex.Matches(input);
                List<string> list = new List<string>();

                foreach (Match m in matches)
                {
                    list.Add($"{m.Groups["one"].Value} {m.Groups["two"].Value}");
                    list.Add($"{m.Groups["three"].Value} {m.Groups["four"].Value}");
                }

                list = list.Where(a => a != " ").ToList();

                if (list.Count == 1)
                {
                    foreach (var item in list)
                    {
                        string[] tokens = item.Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
                        string street = tokens[0];
                        string number = tokens[1];
                        string password = tokens[2];

                        Console.WriteLine($"Go to str. {street} {number}. Secret pass: {password}.");
                    }
                }
                else if(list.Count % 2 == 0)
                {
                    foreach (var item in list.Where((item, index) => index % 2 != 0))
                    {
                        string[] tokens = item.Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
                        string street = tokens[0];
                        string number = tokens[1];
                        string password = tokens[2];

                        Console.WriteLine($"Go to str. {street} {number}. Secret pass: {password}.");
                    }
                }
                else if(list.Count % 2 != 0)
                {
                    for (int j = 0; j < list.Count; j+=2)
                    {
                        string[] tokens = list[i].Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
                        string street = tokens[0];
                        string number = tokens[1];
                        string password = tokens[2];

                        Console.WriteLine($"Go to str. {street} {number}. Secret pass: {password}.");
                        return;
                    }
                }

            }
        }
    }
}
