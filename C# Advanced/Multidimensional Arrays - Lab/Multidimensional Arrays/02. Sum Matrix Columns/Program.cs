using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> matrixInfo = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int rows = matrixInfo[0];
            int cols = matrixInfo[1];

            int[,] matrix = new int[rows, cols];


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                List<int> colElements = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = colElements[j];
                }

            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int colSum = 0;

                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    colSum += matrix[j, i];
                }

                Console.WriteLine(colSum);
            }

          

           

            
        }
    }
}
