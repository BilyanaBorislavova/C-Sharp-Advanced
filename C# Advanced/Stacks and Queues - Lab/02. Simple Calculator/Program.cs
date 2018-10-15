using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
             string input = Console.ReadLine();
             var split = input.Split();
             Stack<string> stack = new Stack<string>(split.Reverse());
            
             while (stack.Count > 1)
             {
                 int num1 = int.Parse(stack.Pop());
                 string operand = stack.Pop();
                 int num2 = int.Parse(stack.Pop());
            
                 if(operand == "+")
                 {
                     stack.Push((num1 + num2).ToString());
                 }
                 else
                 {
                     stack.Push((num1 - num2).ToString());
                 }
             }
            
             Console.WriteLine(stack.Pop());       
        }     
    }
}
