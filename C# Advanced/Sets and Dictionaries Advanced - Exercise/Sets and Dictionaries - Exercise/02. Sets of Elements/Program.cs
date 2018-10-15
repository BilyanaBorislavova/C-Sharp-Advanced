using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> setLength = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            List<int> listOne = new List<int>();
            List<int> listTwo = new List<int>();

            for (int i = 0; i < setLength[0]; i++)
            {
                int n = int.Parse(Console.ReadLine());
                listOne.Add(n);
            }

            for (int i = 0; i < setLength[1]; i++)
            {
                int m = int.Parse(Console.ReadLine());
                listTwo.Add(m);
            }

            var finalList = listOne.Intersect(listTwo);
            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}
