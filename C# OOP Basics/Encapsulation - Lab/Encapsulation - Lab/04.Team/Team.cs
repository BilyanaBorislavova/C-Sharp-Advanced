using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.Name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public List<Person> FirstTeam
        {
            get { return this.firstTeam; }
        }

        public List<Person> ReserveTeam
        {
            get { return this.reserveTeam; }
        }

        public string Name
        {
            get { return this.Name; }
            set { this.name = value; }
        }

        public void AddPlayer(Person person)
        {
            if(person.Age < 40)
            {
                this.firstTeam.Add(person);
            }
            else
            {
                this.reserveTeam.Add(person);
            }
        }

        public string FindSize()
        {
            string str = $"First team has {firstTeam.Count} players.\nReverse team has {reserveTeam.Count} players.";
            return str;
        }
    }
}
