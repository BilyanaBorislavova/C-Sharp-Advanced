using System;
using System.Collections.Generic;
using System.Linq;

namespace fak4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            char[][] matrix = new char[n][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            }


            int startingRow = 0;
            int startingCol = 0;


            int coalCounter = 0;
            int totalCoals = 0;

            for (int row = 0; row < matrix.Length; row++)
            {
                 for (int col = 0; col < matrix[row].Length; col++)
                 {
                     if (matrix[row][col] == 's')
                     {
                         startingRow = row;
                         startingCol = col;
                     }

                     if(matrix[row][col] == 'c')
                     {
                        totalCoals++;
                     }
                 }
            }

            bool allCollected = false;
            int countCommands = 0;
            int totalCommands = commands.Count();
            //Console.WriteLine($"{startingRow} {startingCol}");
            foreach (var cmd in commands)
            {
                if(cmd == "up")
                {
                    if (startingRow - 1 >= 0 && startingRow - 1 <= matrix.Length - 1)
                    {
                        startingRow -= 1;
                    }
                }
                else if(cmd == "right")
                {
                    if(startingCol + 1 >= 0 && startingCol + 1 < matrix[startingRow].Length)
                    {
                        startingCol += 1;
                    }
                }
                else if(cmd == "down")
                {
                    if (startingRow + 1 >= 0 && startingRow + 1 <= matrix.Length - 1)
                    {
                        startingRow += 1;
                    }
                }
                else if(cmd == "left")
                {
                    if (startingCol - 1 >= 0 && startingCol - 1 < matrix[startingRow].Length)
                    {
                        startingCol -= 1;
                    }
                }
                //Console.WriteLine($"{startingRow} {startingCol}");
                if (matrix[startingRow][startingCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({startingRow}, {startingCol})");
                    break;
                }
                else if (matrix[startingRow][startingCol] == 'c')
                {
                    coalCounter++;
                    matrix[startingRow][startingCol] = '*';

                    if (totalCoals == coalCounter)
                    {
                        allCollected = true;
                        Console.WriteLine($"You collected all coals! ({startingRow}, {startingCol})");
                        break;
                    }
   
                }

                countCommands++;
            }

            if(!allCollected && countCommands == totalCommands)
            {
                    Console.WriteLine($"{totalCoals - coalCounter} coals left. ({startingRow}, {startingCol})");
 
            }

        }
    }
}
