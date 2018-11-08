using System;
using System.Collections.Generic;

public class Program
    {
        public static void Main(string[] args)
        {
        string command = Console.ReadLine();
        NationsBuilder nations = new NationsBuilder();

        while (command != "Quit")
        {
            string[] info = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if(info[0] == "Bender")
            {
                List<string> listArgs = new List<string>();
                for (int i = 1; i < info.Length; i++)
                {
                    listArgs.Add(info[i]);
                }

                nations.AssignBender(listArgs);
            }
            else if(info[0] == "Monument")
            {
                List<string> monumentArgs = new List<string>();
                for (int i = 1; i < info.Length; i++)
                {
                    monumentArgs.Add(info[i]);
                }

                nations.AssignMonument(monumentArgs);
            }
            else if(info[0] == "Status")
            {
                nations.GetStatus(info[1]);
            }
            else if(info[0] == "War")
            {

            }

            command = Console.ReadLine();
        }
        }
    }

