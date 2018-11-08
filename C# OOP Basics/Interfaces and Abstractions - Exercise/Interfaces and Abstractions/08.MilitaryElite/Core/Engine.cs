using MilitaryElite.Classes;
using MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite.Core
{
    public class Engine
    {
        public void Run()
        {
            string cmd = Console.ReadLine();

            List<Private> privateList = new List<Private>();

            while (cmd != "End")
            {
                string[] info = cmd.Split(new char[] {' ' },StringSplitOptions.RemoveEmptyEntries);
                string command = info[0];

                if (command == "Private")
                {
                    Private privates = new Private(info[1], info[2], info[3], decimal.Parse(info[4]));
                    privateList.Add(privates);
                    Console.WriteLine(privates.ToString());
                }
                else if (command == "LieutenantGeneral")
                {
                    LeutenantGeneral leutenant = new LeutenantGeneral(info[1], info[2], info[3], decimal.Parse(info[4]));
                    Console.WriteLine(leutenant.ToString());

                    for (int i = 5; i < info.Length; i++)
                    {
                        var finalPrivate = privateList.Where(a => a.Id == info[i]);

                        foreach (var p in finalPrivate)
                        {
                            Console.WriteLine($"  Name: {p.FirstName} {p.LastName} Id: {p.Id} Salary: {p.Salary:f2}");
                        }
                    }
                }
                else if (command == "Engineer")
                {
                    if (info[5] == "Airforces" || info[5] == "Marines")
                    {
                        Engineer engineer = new Engineer(info[1], info[2], info[3], decimal.Parse(info[4]), Enum.Parse<Corps>(info[5]));
                        Console.WriteLine(engineer.ToString());

                        for (int i = 6; i < info.Length; i += 2)
                        {
                            string name = info[i];
                            string hours = info[i + 1];
                            Repair repair = new Repair(name, hours);
                            engineer.repairs.Add(repair);
                        }

                        foreach (var repair in engineer.repairs)
                        {
                            Console.WriteLine($"  Part Name: {repair.Name} Hours Worked: {repair.HoursWorked}");
                        }
                    }
                }
                else if (command == "Commando")
                {
                    Commando commando = new Commando(info[1], info[2], info[3], decimal.Parse(info[4]), Enum.Parse<Corps>(info[5]));
                    Console.WriteLine(commando.ToString());

                    for (int i = 6; i < info.Length; i+=2)
                    {
                        string code = info[i];
                        string state = info[i + 1];
                        if (state == "inProgress" || state == "Finished")
                        {
                            Mission mission = new Mission(code, Enum.Parse<States>(state));
                            commando.missions.Add(mission);
                        }
                    }

                    foreach (var mission in commando.missions)
                    {
                        Console.WriteLine($"  Code Name: {mission.CodeName} State: {mission.states}");
                    }

                }
                else if (command == "Spy")
                {
                    Spy spy = new Spy(info[1], info[2], info[3], int.Parse(info[4]));
                    Console.WriteLine(spy.ToString());
                }


                cmd = Console.ReadLine();
            }
        }
    }
}
