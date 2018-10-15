using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> numberOccurence = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!numberOccurence.ContainsKey(number))
                {
                    numberOccurence.Add(number, 1);
                }
                else
                {
                    numberOccurence[number] += 1;
                }

            }

            foreach (var number in numberOccurence.Where(a => a.Value % 2 == 0))
            {
                Console.WriteLine(number.Key);
            }
        }
    }
}
