using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string colour = input[0];
                string[] outfit = input[1].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

                if (!dict.ContainsKey(colour))
                {
                    dict.Add(colour, new Dictionary<string, int>());
                }

               foreach (var clothing in outfit)
               {
                    if (!dict[colour].ContainsKey(clothing))
                    {
                        dict[colour].Add(clothing, 1);
                    }
                    else
                    {
                        dict[colour][clothing] += 1;
                    }
               }

            }

            string[] colourAndItemToLookFor = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string color = colourAndItemToLookFor[0];
            string item = colourAndItemToLookFor[1];


            foreach (var clothing in dict)
            {
                Console.WriteLine($"{clothing.Key} clothes:");

                foreach (var outfit in clothing.Value)
                {
                    if (clothing.Key == color && outfit.Key == item)
                    {
                        Console.WriteLine($"* {outfit.Key} - {outfit.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {outfit.Key} - {outfit.Value}");
                    }
                }
            }
          
        }
    }
}
