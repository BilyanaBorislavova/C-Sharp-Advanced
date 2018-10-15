using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace _02._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersToUse = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int numsToPush = numbersToUse[0];
            int numsToPop = numbersToUse[1];
            int elementToLookFor = numbersToUse[2];

            List<int> nums = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Stack<int> stack = new Stack<int>(nums.Take(numsToPush));

            for (int i = 0; i < numsToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Count > 0)
            {
                if (stack.Contains(elementToLookFor))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            } else
            {
                Console.WriteLine("0");
            }


        }
    }
}
