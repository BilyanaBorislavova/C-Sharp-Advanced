using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            int primaryDiagonal = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                List<int> colElements = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                primaryDiagonal += colElements[i];
            }

            Console.WriteLine(primaryDiagonal);
        }
    }
}
