using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Jedi_Meditation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder m = new StringBuilder();
            StringBuilder k = new StringBuilder();
            StringBuilder guys = new StringBuilder();
            StringBuilder p = new StringBuilder();
            bool yoda = false;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in input)
                {
                    char ch = item[0];

                    if(ch == 'm')
                    {
                        m.Append(item + " ");
                    }
                    else if(ch == 'k')
                    {
                        k.Append(item + " ");
                    }
                    else if(ch == 's' || ch == 't')
                    {
                        guys.Append(item + " ");
                    }
                    else if(ch == 'p')
                    {
                        p.Append(item + " ");
                    }
                    else if(ch == 'y')
                    {
                        yoda = true;
                    }
                }
            }

            if(yoda)
            {
                Console.Write($"{m}{k}{guys}{p}");
            }
            else
            {
                Console.Write($"{guys}{m}{k}{p}");
            }

            Console.WriteLine();
        }
    }
}
