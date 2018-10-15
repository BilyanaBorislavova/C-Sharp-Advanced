using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> values = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(double.Parse)
                 .ToList();

            Dictionary<double, int> dictionary = new Dictionary<double, int>();

            foreach (var num in values)
            {
                if(!dictionary.ContainsKey(num))
                {
                    dictionary.Add(num, 1);
                }
                else
                {
                    dictionary[num] += 1;
                }
            }

            foreach (var value in dictionary)
            {
                Console.WriteLine($"{value.Key} - {value.Value} times");
            }
        }
    }
}
