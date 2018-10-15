using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Jedi_Galaxy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> matrixSize = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int[][] matrix = new int[matrixSize[0]][];

            int counter = 0;

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[matrixSize[1]];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = counter;
                    counter++;
                }
            }

            string input = Console.ReadLine();

            long sum = 0;
            
            while (input != "Let the Force be with you")
            {
                int[] ivoPosition = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int[] evilPosition = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                while (evilPosition[0] >= 0 && evilPosition[1]>= 0)
                {
                    if(evilPosition[0] >= 0 && evilPosition[0] <= matrix.Length - 1 && evilPosition[1] >= 0 && evilPosition[1] < matrix[evilPosition[0]].Length)
                    {
                        matrix[evilPosition[0]][evilPosition[1]] = 0;
                    }
                    evilPosition[0]--;
                    evilPosition[1]--;
                }

                while (ivoPosition[0] >= 0 && ivoPosition[1] < matrix[0].Length)
                {
                    if (ivoPosition[0] >= 0 && ivoPosition[0] <= matrix.Length - 1 && ivoPosition[1] >= 0 && ivoPosition[1] < matrix[ivoPosition[0]].Length)
                    {
                        sum += matrix[ivoPosition[0]][ivoPosition[1]];
                    }

                    ivoPosition[0]--;
                    ivoPosition[1]++;
                }
            
                input = Console.ReadLine();
            }

            Console.WriteLine(sum);
        }
    }
}
