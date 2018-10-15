using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Traffic_Light
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsToPass = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            Queue<string> queue = new Queue<string>();
            int counter = 0;

            while (command != "end")
            {
                if(command != "green")
                {
                    queue.Enqueue(command);
                }
                else
                {
                    for (int i = 0; i < carsToPass; i++)
                    {
                        if (queue.Count > 0)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            counter++;
                        }
                    }
                    
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
