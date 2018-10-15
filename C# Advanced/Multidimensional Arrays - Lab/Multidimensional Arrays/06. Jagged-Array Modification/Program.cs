using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rows][];

            for (int i = 0; i < jagged.Length; i++)
            {
                List<int> colElements = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                jagged[i] = new int[colElements.Count];

                for (int j = 0; j < jagged[i].Length; j++)
                {
                    jagged[i][j] = colElements[j];
                }
            }

            string cmd = Console.ReadLine();

            while (cmd != "END")
            {
               string[] tokens = cmd.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);
               
                if(command == "Add")
                {
                    if (row > jagged.Length - 1 || row < 0 || jagged[row].Length - 1 < col || col < 0)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        jagged[row][col] += value;
                    }
                }
                else
                {
                    if (row > jagged.Length - 1 || row < 0 || jagged[row].Length - 1 < col || col < 0)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        jagged[row][col] -= value;
                    }
                }

                cmd = Console.ReadLine();
            }


            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }

                Console.WriteLine();
            }

        }
    }
}
