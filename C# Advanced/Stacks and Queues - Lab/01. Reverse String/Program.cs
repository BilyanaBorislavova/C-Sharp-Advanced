using System;
using System.Collections;
using System.Collections.Generic;

namespace _01._Reverse_String
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            Stack<string> stack = new Stack<string>();

            foreach (var item in str)
            {
                stack.Push(item.ToString());
            }

            foreach (var item in stack)
            {
                Console.Write(item);
            }

            Console.WriteLine();
        }
    }
}
