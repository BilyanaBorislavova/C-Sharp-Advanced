using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string parentheses = Console.ReadLine();

                int middle = parentheses.Length / 2;
                Queue<char> queue = new Queue<char>(parentheses.Take(middle));

                parentheses = parentheses.Remove(0, middle);

                Stack<char> stack = new Stack<char>(parentheses.Take(middle));

                bool isTrue = false;

                for (int i = 0; i < middle; i++)
                {
                    char dequeue = queue.Dequeue();
                    char pop = stack.Pop();

                    if (dequeue == '(' && pop == ')')
                    {
                        isTrue = true;
                    }
                    else if (dequeue == '{' && pop == '}')
                    {
                        isTrue = true;
                    }
                    else if (dequeue == '[' && pop == ']')
                    {
                        isTrue = true;
                    }
                    else
                    {
                        isTrue = false;
                    }
                }

                if (isTrue)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
             
        }
    }
}
