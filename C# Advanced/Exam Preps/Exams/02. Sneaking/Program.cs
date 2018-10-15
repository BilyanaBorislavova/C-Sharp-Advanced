using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sneaking
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[][] matrix = new char[matrixSize][];

            for (int row = 0; row < matrixSize; row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();
            }

            int samRow = 0;
            int samCol = 0;

            char[] commands = Console.ReadLine().ToCharArray();

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if(matrix[row][col] == 'S')
                    {
                        samRow = row;
                        samCol = col;
                    }
                }
            }

            bool inLoop = false;

            foreach (var cmd in commands)
            {

                for (int row = 0; row < matrix.Length; row++)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        if (matrix[row][col] == 'b')
                        {
                            if (col + 1 < matrix[row].Length)
                            {
                                matrix[row][col] = '.';
                                matrix[row][col + 1] = 'b';
                                col += 2;
                            }
                            else
                            {
                                matrix[row][col] = 'd';
                            }
                        }

                        if (matrix[row][col] == 'd')
                        {
                            if(col - 1 >= 0)
                            {
                                matrix[row][col] = '.';
                                matrix[row][col - 1] = 'd';
                            }
                            else
                            {
                                matrix[row][col] = 'b';
                            }
                        }
                    }

                    if (matrix[row].Contains('S') && matrix[row].Contains('b'))
                    {
                        if (Array.IndexOf(matrix[row], 'S') > Array.IndexOf(matrix[row], 'b'))
                        {
                            matrix[row][Array.IndexOf(matrix[row], 'S')] = 'X';
                            Console.WriteLine($"Sam died at {row}, {Array.IndexOf(matrix[row], 'X')}");
                            inLoop = true;
                        }
                    }
                    else if (matrix[row].Contains('S') && matrix[row].Contains('d'))
                    {
                        if (Array.IndexOf(matrix[row], 'S') < Array.IndexOf(matrix[row], 'd'))
                        {
                            matrix[row][Array.IndexOf(matrix[row], 'S')] = 'X';
                            Console.WriteLine($"Sam died at {row}, {Array.IndexOf(matrix[row], 'X')}");
                            inLoop = true;
                        }
                    }
                    else if (matrix[row].Contains('S') && matrix[row].Contains('N'))
                    {
                        matrix[row][Array.IndexOf(matrix[row], 'N')] = 'X';
                        Console.WriteLine($"Nikoladze killed!");
                        inLoop = true;
                    }
                }

                if(cmd == 'U')
                {
                    if(samRow - 1 >= 0)
                    {
                        matrix[samRow][samCol] = '.';
                        matrix[samRow - 1][samCol] = 'S';
                        samRow -= 1;
                    }
                }
                else if(cmd == 'D')
                {
                 
                    if(samRow + 1 >= 0 && samRow + 1 < matrix.Length)
                    {
                        matrix[samRow][samCol] = '.';
                        matrix[samRow + 1][samCol] = 'S';
                        samRow += 1;
                    }
                }
                else if(cmd == 'L')
                {
                    if(samCol - 1 >= 0 && samCol - 1 < matrix[samRow].Length)
                    {
                        matrix[samRow][samCol] = '.';
                        matrix[samRow][samCol - 1] = 'S';
                        samCol -= 1;
                    }
                }
                else if(cmd == 'R')
                {
                    if (samCol + 1 >= 0 && samCol + 1 < matrix[samRow].Length)
                    {
                        matrix[samRow][samCol] = '.';
                        matrix[samRow][samCol + 1] = 'S';
                        samCol += 1;
                    }
                }
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }

        }
    }
}
