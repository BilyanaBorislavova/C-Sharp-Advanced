using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> matrixSize = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            char[][] matrix = new char[matrixSize[0]][];

            for (int row = 0;  row < matrix.Length;  row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();
            }

            int money = 50;
            int totalHotels = 0;
            int turns = 0;

            for (int row = 0; row < matrix.Length; row++)
            {
                if(row % 2 == 0)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        char currentChar = matrix[row][col];

                        if(currentChar == 'H')
                        {
                            totalHotels++;
                            Console.WriteLine($"Bought a hotel for {money}. Total hotels: {totalHotels}.");
                            money -= money;
                        }
                        else if(currentChar == 'J')
                        {
                            Console.WriteLine($"Gone to jail at turn {turns}.");
                            turns += 2;

                            money +=  (10 * totalHotels)* 2;
                        }
                        else if(currentChar == 'F')
                        {

                        }
                        else if(currentChar == 'S')
                        {
                            int moneyToSpend = (row + 1) * (col + 1);

                            if (moneyToSpend > money)
                            {
                                money = moneyToSpend;
                            }

                            Console.WriteLine($"Spent {moneyToSpend} money at the shop.");

                            money -= moneyToSpend;
                        }
                        turns++;
                        money += totalHotels * 10;
                    }
                }
                else
                {
                    for (int col = matrix[row].Length - 1; col >= 0; col--)
                    {
                        char currentChar = matrix[row][col];


                        if (currentChar == 'H')
                        {
                            totalHotels++;
                            Console.WriteLine($"Bought a hotel for {money}. Total hotels: {totalHotels}.");
                            money -= money;
                        }
                        else if (currentChar == 'J')
                        {
                            Console.WriteLine($"Gone to jail at turn {turns}.");
                            turns += 2;

                            money += (10 * totalHotels) * 2;
                        }
                        else if (currentChar == 'F')
                        {

                        }
                        else if (currentChar == 'S')
                        {
                            int moneyToSpend = (row + 1) * (col + 1);

                            if(moneyToSpend > money)
                            {
                                money = moneyToSpend;
                            }

                            Console.WriteLine($"Spent {moneyToSpend} money at the shop.");
                            money -= moneyToSpend;
                        }
                        turns++;
                        money += totalHotels * 10;
                    }
                }
            }

            Console.WriteLine($"Turns {turns}");
            Console.WriteLine($"Money {money}");
        }
    }
}
