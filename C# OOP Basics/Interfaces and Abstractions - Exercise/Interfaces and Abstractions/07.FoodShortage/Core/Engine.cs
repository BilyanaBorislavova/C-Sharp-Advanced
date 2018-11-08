using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodShortage.Core
{
    public class Engine
    {
        public void Run()
        {
            int n = int.Parse(Console.ReadLine());

            List<string> citizens = new List<string>();
            List<string> rebels = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (info.Length == 4)
                {
                    Citizen citizen = new Citizen(info[0], int.Parse(info[1]), info[2], info[3]);
                    citizens.Add(citizen.Name);
                }
                else if (info.Length == 3)
                {
                    Rebel rebel = new Rebel(info[0], int.Parse(info[1]), info[2]);
                    rebels.Add(rebel.Name);
                }
            }

            int count = 0;
            while (true)
            {
               string command = Console.ReadLine();

                if(command == "End")
                {
                    break;
                }

                var c = citizens.Where(a => a == command);
                foreach (var citizn in c)
                {
                    count += 10;
                }

                var r = rebels.Where(a => a == command);
                foreach (var rebel in r)
                {
                    count += 5;
                }
            }

            Console.WriteLine(count);
        }
    }
}
