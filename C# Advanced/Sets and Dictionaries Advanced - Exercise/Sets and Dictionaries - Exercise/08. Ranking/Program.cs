using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string contests = Console.ReadLine();

            Dictionary<string, string> contestDictionary = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> dictionary = new Dictionary<string, Dictionary<string, int>>(); 

            while (contests != "end of contests")
            {
                string[] contestInfo = contests.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                string contest = contestInfo[0];
                string password = contestInfo[1];

                if(!contestDictionary.ContainsKey(contest))
                {
                    contestDictionary.Add(contest, password);
                }

                contests = Console.ReadLine();
            }

            string submissions = Console.ReadLine();

            while (submissions != "end of submissions")
            {
                string[] info = submissions.Split(new string[] { "=>" }, StringSplitOptions.RemoveEmptyEntries);
                string contest = info[0];
                string password = info[1];
                string username = info[2];
                int points = int.Parse(info[3]);

                if(contestDictionary.ContainsKey(contest))
                {
                    if(contestDictionary[contest] == password)
                    {
                        if(!dictionary.ContainsKey(username))
                        {
                            dictionary.Add(username, new Dictionary<string, int>());
                        }

                        if(!dictionary[username].ContainsKey(contest))
                        {
                            dictionary[username].Add(contest, points);
                        }

                        if(dictionary[username][contest] < points)
                        {
                            dictionary[username][contest] = points;
                        }
                    }
                }

                submissions = Console.ReadLine();
            }


            List<string> results = new List<string>();

            foreach (var contestant in dictionary.OrderBy(a => a.Value.Values.Max()))
            {
                int totalSum = 0;
                foreach (var points in contestant.Value)
                {
                    totalSum += points.Value;
                }

                results.Add($"Best candidate is {contestant.Key} with total {totalSum} points.");
            }

            Console.WriteLine(results.Last());

            Console.WriteLine("Ranking:");

            foreach (var contestant in dictionary.OrderBy(a => a.Key))
            {
                Console.WriteLine(contestant.Key);

                foreach (var points in contestant.Value.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"#  {points.Key} -> {points.Value}");
                }
            }
        }
    }
}
