using System;
using System.Collections.Generic;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, HashSet<string>>> dict = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            while (input != "Statistics")
            {
                string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if(input.Contains("joined"))
                {
                    string vloggerName = tokens[0];

                    if(!dict.ContainsKey(vloggerName))
                    {
                        dict.Add(vloggerName, new Dictionary<string, HashSet<string>>());
                        dict[vloggerName].Add("Following", new HashSet<string>());
                        dict[vloggerName].Add("Followed", new HashSet<string>());
                    }
                    
                }
                else if(input.Contains("followed"))
                {
                    string follower = tokens[0];
                    string followed = tokens[2];

                    if(dict.ContainsKey(follower) && follower != followed && dict.ContainsKey(followed))
                    {
                        dict[follower]["Followed"].Add(followed);
                        dict[followed]["Following"].Add(follower);
                    }

                   
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {dict.Keys.Count} vloggers in its logs.");

            int counter = 1;

            foreach (var vlogger in dict)
            {
                Console.WriteLine($"{counter}. {vlogger.Key} : {vlogger.Value.Count} following, ");
                foreach (var item in vlogger.Value)
                {

                }
            }
        }
    }
}
