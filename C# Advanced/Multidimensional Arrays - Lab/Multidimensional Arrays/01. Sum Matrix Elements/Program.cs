
using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> matrixInfo = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int rows = matrixInfo[0];
            int cols = matrixInfo[1];

            int[,] matrix = new int[rows, cols];

            Console.WriteLine(rows);
            Console.WriteLine(cols);

            int totalSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                foreach (var item in colElements)
                {
                    totalSum += item;
                }
            }

            Console.WriteLine(totalSum);
        }
    }
}
