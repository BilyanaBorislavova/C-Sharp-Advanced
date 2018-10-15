using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace _04._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if (input[i] == ')')
                {
                    int length = i - stack.Peek();
                    Console.WriteLine(input.Substring(stack.Pop(), length + 1));
                }
            }

        }
    }
}
