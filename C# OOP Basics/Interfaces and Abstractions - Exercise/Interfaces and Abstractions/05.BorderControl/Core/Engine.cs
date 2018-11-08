using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BorderControl.Core
{
    public class Engine
    {
        public void Run()
        {
            string command = Console.ReadLine();

            List<string> ids = new List<string>();

            while (command != "End")
            {
                string[] info = command.Split(' ');

                if(info.Length == 2)
                {
                    string model = info[0];
                    string id = info[1];

                    Robots robots = new Robots(model, id);
                    ids.Add(robots.Id);
                }
                else if(info.Length == 3)
                {
                    string name = info[0];
                    int age = int.Parse(info[1]);
                    string id = info[2];

                    Citizens citizens = new Citizens(name, age, id);
                    ids.Add(citizens.Id);
                }

                command = Console.ReadLine();
            }

            string number = Console.ReadLine();
            var finalIds = ids.Where(a => a.EndsWith(number));
            foreach (var id in finalIds)
            {
                Console.WriteLine(id);
            }
        }




    }
}
