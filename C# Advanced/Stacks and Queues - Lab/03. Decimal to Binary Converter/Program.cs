using System;
using System.Collections;
using System.Collections.Generic;

namespace _03._Decimal_to_Binary_Converter
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            if(n == 0)
            {
                Console.WriteLine("0");
            } 
            else
            {
                while (n > 0)
                {
                    stack.Push(n % 2);
                    n /= 2;
                }
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
