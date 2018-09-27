using System;
using System.Collections.Generic;
using System.Linq;

namespace _05__Rubik_s_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> matrixSize = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[matrixSize[0]][];

            int incrementNumber = 1;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrixSize[1]; j++)
                {
                    matrix[i][j] = incrementNumber;
                }
            }

            foreach (var item in matrix)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string direction = commands[1];
                int moves = int.Parse(commands[2]);

                if(direction == "up" || direction == "down")
                {
                    string column = commands[0];

                }
                else if(direction == "left" || direction == "right")
                {
                    string row = commands[0];
                }
                
            }
        }
    }
}
