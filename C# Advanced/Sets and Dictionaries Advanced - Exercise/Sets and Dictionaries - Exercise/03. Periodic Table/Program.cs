using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> chemicalCompounds = new List<string>();
            SortedSet<string> uniqueChemicals = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string cheminals = Console.ReadLine();
                chemicalCompounds.Add(cheminals);
            }

            foreach (var item in chemicalCompounds)
            {
                string[] split = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item1 in split)
                {
                    uniqueChemicals.Add(item1);
                }
            }

            foreach (var chemical in uniqueChemicals)
            {
                Console.Write(chemical + " ");
            }
            Console.WriteLine();
           
        }
    }
}
