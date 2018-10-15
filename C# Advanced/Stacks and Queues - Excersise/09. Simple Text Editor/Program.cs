using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string str = "";

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                List<string> commands = Console.ReadLine()
                    .Split()
                    .ToList();

                if(commands[0] == "1")
                {
                    stack.Push(str);
                    string text = commands[1];
                    str += text;
                }
                else if(commands[0] == "2")
                {
                    stack.Push(str);
                    int count = int.Parse(commands[1]);

                    str = str.Remove(str.Length - count);
                } 
                else if(commands[0] == "3")
                {
                    int index = int.Parse(commands[1]);
                    Console.WriteLine(str[index - 1]);
                }
                else if(commands[0] == "4")
                {
                    str = stack.Pop();
                }
            }

        }
    }
}
