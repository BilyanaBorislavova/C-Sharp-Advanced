using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Poisonous_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPlants = int.Parse(Console.ReadLine());

            List<int> pesticides = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list = new List<int>();

            for (int i = 0; i < pesticides.Count - 1; i++)
            {
                if(pesticides[i] >
                    pesticides[i + 1])
                {
                    list.Add(pesticides[i + 1]);
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
