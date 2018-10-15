using System;
using System.Collections.Generic;
using System.Linq;

namespace fak3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cups = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> bottles = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (cups.Count > 0 && bottles.Count > 0)
            {
                int cup = cups[0];
                cups.RemoveAt(0);

                while (cup > 0 && bottles.Count > 0)
                {
                    int bottle = bottles[bottles.Count - 1];
                    bottles.RemoveAt(bottles.Count - 1);

                    if (bottle > cup)
                    {
                        int diff = bottle - cup;

                        if (bottles.Count > 0)
                        {
                            bottles[bottles.Count - 1] += diff;
                        }
                        else
                        {
                            bottles.Add(diff);
                        }
                    }

                    cup -= bottle;
                }

            }

            if (cups.Count > 0)
            {
                Console.WriteLine(string.Join(" ", cups));
            }
            else
            {
                bottles.Reverse();
                Console.WriteLine(string.Join(" ", bottles));
            }
        }
    }
}
