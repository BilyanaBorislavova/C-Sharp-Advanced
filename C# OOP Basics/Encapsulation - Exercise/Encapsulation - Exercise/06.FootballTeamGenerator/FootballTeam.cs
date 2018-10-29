using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    class FootballTeam
    {
        private List<Player> players;
        private string name;
        private int rating;

        public FootballTeam(string name)
        {
            this.Name = name;
            this.Rating = rating;
            this.Players = new List<Player>();
        }

        private List<Player> Players
        {
            get => players;
            set { this.players = value; }       
        }

        private string Name
        {
            get => name;
            set
            {
                if(value == null || value == " " || value == "")
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }

        private int Rating
        {
            get => rating;
            set { this.rating = value; }
        }

        public void AddPlayer(Player player)
        {
            this.Players.Add(player);
        }

        public void RemovePlayer(Player player)
        {
           if(!this.players.Contains(player))
            {
                throw new ArgumentException($"Player {player.Name} is not in {this.name} team.");
            }
            this.players.Remove(player);
        }
    }
}
