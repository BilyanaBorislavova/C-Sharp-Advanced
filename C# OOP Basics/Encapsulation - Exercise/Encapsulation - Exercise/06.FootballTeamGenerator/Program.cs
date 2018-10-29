using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<FootballTeam> teams = new List<FootballTeam>();
            List<Player> players = new List<Player>();

            while (command != "END")
            {
                string[] info = command.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                string teamName = info[1];

                try
                {
                    FootballTeam team = new FootballTeam(teamName);
                    teams.Add(team);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }

                if(command.Contains("Add"))
                {
                    string playerName = info[2];
                    int endurance = int.Parse(info[3]);
                    int sprint = int.Parse(info[4]);
                    int dribble = int.Parse(info[5]);
                    int passing = int.Parse(info[6]);
                    int shooting = int.Parse(info[7]);

                    try
                    {
                        Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                        players.Add(player);
                        teams[0].AddPlayer(player);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Environment.Exit(0);
                    }
                }
                else if(command.Contains("Remove"))
                {
                    string playerName = info[2];
                    try
                    {
                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Environment.Exit(0);
                    }
                }
                else if(command.Contains("Rating"))
                {

                }

                command = Console.ReadLine();
            }

            foreach (var t in teams)
            {
                Console.WriteLine(t);
            }
        }
    }
}
