using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Hit_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetInfoIndex = int.Parse(Console.ReadLine());

            string commands = Console.ReadLine();

            Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>();

            int indexSum = 0;

            while (commands != "end transmissions")
            {
                string[] tokens = commands.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string[] moreInfo = tokens[1].Split(new char[] {';' },StringSplitOptions.RemoveEmptyEntries);

                if(!dictionary.ContainsKey(name))
                {
                    dictionary.Add(name, new Dictionary<string, string>());
                }

                foreach (var info in moreInfo)
                {
                    string[] splitInfo = info.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                    string currentInfo = splitInfo[0];
                    string stats = splitInfo[1];

                    if(!dictionary[name].ContainsKey(currentInfo))
                    {
                        dictionary[name].Add(currentInfo, stats);
                    }
                    else
                    {
                        dictionary[name][currentInfo] = stats;
                    }

                }
                commands = Console.ReadLine();
            }

            string[] kill = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string personToKill = kill[1];

            Console.WriteLine($"Info on {personToKill}:");

            foreach (var infoStats in dictionary[personToKill].OrderBy(a => a.Key))
            {
                Console.WriteLine($"---{infoStats.Key}: {infoStats.Value}");

                indexSum += infoStats.Key.Length + infoStats.Value.Length;
                Console.WriteLine(indexSum);
            }

            Console.WriteLine($"Info index: {targetInfoIndex}");

            if(indexSum >= targetInfoIndex)
            {
                Console.WriteLine("Proceed");
            }
            else
            {
                Console.WriteLine($"Need {targetInfoIndex - indexSum} more info.");
            }
        }
    }
}
