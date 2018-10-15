using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                List<int> nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                if(nums[0] == 1)
                {
                    int numOne = nums[0];
                    int numToPushIntoStack = nums[1];

                    stack.Push(numToPushIntoStack);
                }
                else if(nums[0] == 2)
                {
                    stack.Pop();
                }
                else if(nums[0] == 3)
                {
                    Console.WriteLine(stack.Max());
                }
            }
        }
    }
}
