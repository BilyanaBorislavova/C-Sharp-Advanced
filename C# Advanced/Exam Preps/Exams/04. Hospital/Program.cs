using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, long>> meteors = new Dictionary<string, Dictionary<string, long>>();

            while (input != "Count em all")
            {
                string[] meteorInfo = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string regionName = meteorInfo[0];
                string meteorType = meteorInfo[1];
                long count = long.Parse(meteorInfo[2]);

                if(!meteors.ContainsKey(regionName))
                {
                    meteors.Add(regionName, new Dictionary<string, long>());
                    meteors[regionName].Add("Red", 0);
                    meteors[regionName].Add("Black", 0);
                    meteors[regionName].Add("Green", 0);
                }

                meteors[regionName][meteorType] += count;

                if(meteors[regionName]["Green"] >= 1000000)
                {
                    meteors[regionName]["Red"] += meteors[regionName]["Green"] / 1000000;
                    meteors[regionName]["Green"] = (meteors[regionName]["Green"] % 1000000);
                }

                if(meteors[regionName]["Red"] >= 1000000)
                {
                    meteors[regionName]["Black"] += meteors[regionName]["Red"] / 1000000;
                    meteors[regionName]["Red"] = (meteors[regionName]["Red"] % 1000000);
                }

                input = Console.ReadLine();
            }

            foreach (var region in meteors.OrderByDescending(a => a.Value["Black"]).ThenBy(a => a.Key.Length).ThenBy(a => a.Key))
            {
                Console.WriteLine(region.Key);

                foreach (var meteor in region.Value.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
                {
                    Console.WriteLine($"-> {meteor.Key} : {meteor.Value}");
                }
            }
        }
    }
}
