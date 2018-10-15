using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var str = Console.ReadLine().ToCharArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = str[j];
                    
                }
            }

            char chToLookFor = char.Parse(Console.ReadLine());
            bool occurs = false;
            string index = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if((char)matrix[i,j] == chToLookFor)
                    {
                         Console.WriteLine($"({i}, {j})");
                        return;
                       
                    }
                    else
                    {
                        occurs = false;
                    }
                }
            }
       
            Console.WriteLine($"{chToLookFor} does not occur in the matrix");
        }
    }
}
