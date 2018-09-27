using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[][] matrix = new int[size][];

            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            

            for (int row = 0; row < matrix.Length; row++)
            {
                   matrix[row] = Console.ReadLine()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();         
            }


            for (int row = 0; row < matrix.Length; row++)
            {
                primaryDiagonal += matrix[row][row];
              
            }

            for (int row = matrix.Length - 1; row >= 0; row--)
            {

                secondaryDiagonal += matrix[row][matrix[row].Length - 1 - row];
                
            }

            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
            
        }
    }
}
