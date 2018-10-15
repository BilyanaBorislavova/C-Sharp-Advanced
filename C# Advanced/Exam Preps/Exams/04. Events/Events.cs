using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Events
{
    class Program
    {
        static void Main(string[] args)
        {
            int eventsToRegister = int.Parse(Console.ReadLine());

            SortedDictionary<string, Dictionary<string, List<TimeSpan>>> dictionary = new SortedDictionary<string, Dictionary<string, List<TimeSpan>>>();

            Regex regex = new Regex(@"^#([A-Za-z]+):\s*@([A-Za-z]+)\s*([0-9]{2}:[0-9]{2})$");

            for (int i = 0; i < eventsToRegister; i++)
            {
                string events = Console.ReadLine();

                MatchCollection matches = regex.Matches(events);

                foreach (Match item in matches)
                {
                    try
                    {
                        var s = item.Groups[3].Value;
                        TimeSpan time = TimeSpan.Parse(s);

                        string name = item.Groups[1].Value;
                        string city = item.Groups[2].Value;

                        if (!dictionary.ContainsKey(city))
                        {
                            dictionary.Add(city, new Dictionary<string, List<TimeSpan>>());
                        }

                        if (!dictionary[city].ContainsKey(name))
                        {
                            dictionary[city].Add(name, new List<TimeSpan>());
                        }
                        dictionary[city][name].Add(time);
                    }
                    catch
                    {
                        //
                    }
                }
            }

            string[] locations = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            SortedSet<string> set = new SortedSet<string>(locations);

            foreach (var location in set)
            {
                if (dictionary.ContainsKey(location))
                {
                    Console.WriteLine($"{location}:");
                    int counter = 0;

                    foreach (var item in dictionary[location].OrderBy(a => a.Key))
                    {
                        string str = "";

                        foreach (var itemm in item.Value.OrderBy(a => a))
                        {
                            string[] split = itemm.ToString().Split(':');
                            str += $"{split[0]}:{split[1]}, ";
                        }

                        Console.WriteLine($"{++counter}. {item.Key} -> {str.Substring(0, str.Length - 2)}");
                    }
                }
            }
        }
    }
}
