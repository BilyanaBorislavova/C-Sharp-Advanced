using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var inputToCharArray = input.ToCharArray();

            Dictionary<char, int> countInputSymbols = new Dictionary<char, int>();

            foreach (var ch in inputToCharArray)
            {
                if(!countInputSymbols.ContainsKey(ch))
                {
                    countInputSymbols.Add(ch, 1);
                }
                else
                {
                    countInputSymbols[ch] += 1;
                }
            }

            foreach (var ch in countInputSymbols.OrderBy(a => a.Key))
            {
                Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
            }
        }
    }
}
