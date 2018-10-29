using System;

namespace _01._Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char asteriks = '*';

            PrintRhombus(n, asteriks);
        }

        private static void PrintRhombus(int n, char asteriks)
        {
            string str = new string('0', n).Replace("0", "* ");

            for (int i = 0; i < n; i++)
            {
                Print(n, i, str);
            }

            for (int i = n - 2; i >= 0; i--)
            {
                Print(n, i, str);
            }
        }

        private static void Print(int n, int i, string str)
        {
            Console.WriteLine($"{new string(' ', n - i - 1)}{str.Substring(0, 2 * i + 1)}");
        }
    }
}
