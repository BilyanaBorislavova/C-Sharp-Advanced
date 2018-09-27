﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> matrixSize = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int rows = matrixSize[0];
            int cols = matrixSize[1];

            int[][] matrix = new int[rows][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            int highestSum = int.MinValue;
            int rowIndex = 0;
            int colIndex = 0;

            for (int row = 0; row < matrix.Length - 2; row++)
            {

                for (int col = 0; col < matrix[row].Length - 2; col++)
                {
                   int sum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] + matrix[row +1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2] + matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];

                    if(sum > highestSum)
                    {
                        highestSum = sum;
                        rowIndex = row;
                        colIndex = col;
                    }
       
                }
            
            }

           Console.WriteLine($"Sum = {highestSum}");
           Console.WriteLine($"{matrix[rowIndex][colIndex]} {matrix[rowIndex][colIndex + 1]} {matrix[rowIndex][colIndex + 2]}");
           Console.WriteLine($"{matrix[rowIndex + 1][colIndex]} {matrix[rowIndex + 1][colIndex + 1]} {matrix[rowIndex + 1][colIndex + 2]}");
           Console.WriteLine($"{matrix[rowIndex + 2][colIndex]} {matrix[rowIndex + 2][colIndex + 1]} {matrix[rowIndex + 2][colIndex + 2]}");

        }
    }
}
