using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> departments = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();

            while (input != "Output")
            {
                string[] hospitalInfo = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string department = hospitalInfo[0];
                string doctor = hospitalInfo[1] + " " + hospitalInfo[2];
                string patient = hospitalInfo[3];

                if (!departments.ContainsKey(department))
                {
                    departments.Add(department, new List<string>());
                }

                if (!departments[department].Contains(patient) && departments[department].Count() < 60)
                {
                    departments[department].Add(patient);
                }

                if (!doctors.ContainsKey(doctor))
                {
                    doctors.Add(doctor, new List<string>());
                }

                if (!doctors[doctor].Contains(patient))
                {
                    doctors[doctor].Add(patient);
                }

                input = Console.ReadLine();
            }

            string commands = Console.ReadLine();

            while (commands != "End")
            {
                string[] outputInfo = commands.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (outputInfo.Length == 1)
                {
                    string department = outputInfo[0];

                    foreach (var patients in departments[department])
                    {
                        Console.WriteLine(patients);
                    }
                }
                else
                {
                    string docName = outputInfo[0] + " " + outputInfo[1];

                    if (doctors.ContainsKey(docName))
                    {
                        foreach (var patients in doctors[docName].OrderBy(a => a))
                        {
                            Console.WriteLine(patients);
                        }
                    }
                    else
                    {
                        string department = outputInfo[0];
                        int room = int.Parse(outputInfo[1]);

                        if (room <= 20)
                        {
                            foreach (var item in departments[department].Skip((room * 3) - 3).Take(3).OrderBy(a => a))
                            {
                                Console.WriteLine(item);
                            }
                        }
                    }
                }

                commands = Console.ReadLine();
            }
        }
    }
}
