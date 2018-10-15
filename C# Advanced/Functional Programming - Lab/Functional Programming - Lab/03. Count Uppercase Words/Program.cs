using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("\n",
                  Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Where(a => a[0] == a.ToUpper()[0])
                 .ToArray()));
        }
    }
}
