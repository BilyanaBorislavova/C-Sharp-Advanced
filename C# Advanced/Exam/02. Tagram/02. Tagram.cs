using System;
using System.Collections.Generic;
using System.Linq;

namespace fak2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            while (input != "end")
            {
                string[] split = input.Split(new string[] { " -> ", " " }, StringSplitOptions.RemoveEmptyEntries);
                
                if(split.Length == 3)
                {
                    string username = split[0];
                    string tag = split[1];
                    int likes = int.Parse(split[2]);

                    if (!dict.ContainsKey(username))
                    {
                        dict.Add(username, new Dictionary<string, int>());
                    }

                    if (!dict[username].ContainsKey(tag))
                    {
                        dict[username].Add(tag, likes);
                    }
                    else
                    {
                        dict[username][tag] += likes;
                    }

                }
                else if(split.Length == 2)
                {
                    string username = split[1];

                    if (dict.ContainsKey(username))
                    {
                        dict.Remove(username);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var person in dict.OrderByDescending(a => a.Value.Values.Sum()).ThenBy(a => a.Value.Keys.Count()))
            {
                Console.WriteLine(person.Key);

                foreach (var item in person.Value)
                {
                    Console.WriteLine($"- {item.Key}: {item.Value}");
                }
            }
        }
    }
}
