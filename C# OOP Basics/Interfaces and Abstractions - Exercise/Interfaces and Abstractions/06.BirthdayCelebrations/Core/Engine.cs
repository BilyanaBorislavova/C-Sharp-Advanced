using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BirthdayCelebrations.Core
{
    public class Engine
    {
        public void Run()
        {
            string command = Console.ReadLine();

            List<string> years = new List<string>();

            while (command != "End")
            {
                string[] info = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);   

                if(info[0] == "Citizen")
                {
                    Citizens citizens = new Citizens(info[1], int.Parse(info[2]), info[3], info[4]);
                    years.Add(citizens.BirthDate);
                }
                else if(info[0] == "Robot")
                {
                    Robots robots = new Robots(info[1], info[2]);
                }
                else if(info[0] == "Pet")
                {
                    Pet pet = new Pet(info[1], info[2]);
                    years.Add(pet.BirthDate);
                }

                command = Console.ReadLine();
            }

            string year = Console.ReadLine();

            var finalYears = years.Where(a => a.EndsWith(year));
            foreach (var y in finalYears)
            {
                Console.WriteLine(y);
            }

        }
    }
}
