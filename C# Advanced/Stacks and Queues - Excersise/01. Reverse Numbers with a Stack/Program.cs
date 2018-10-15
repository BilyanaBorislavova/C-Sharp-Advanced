using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Reverse_Numbers_with_a_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Stack<int> stack = new Stack<int>();

            foreach (var n in numbers)
            {
                stack.Push(n);
            }

            foreach (var n in stack)
            {
                Console.Write(n + " ");
            }

        }
    }
}
