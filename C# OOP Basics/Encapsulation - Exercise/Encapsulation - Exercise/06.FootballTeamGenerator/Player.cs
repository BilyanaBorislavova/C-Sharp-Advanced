using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public string Name
        {
            get => name;
            set
            {
                if (value == null || value == " " || value == "")
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }

        }

        public int Endurance
        {
            get { return endurance; }
            set
            {
                if(value < 0 || value > 100)
                {
                    ThrowError("Endurance");
                }
                this.endurance = value;
            }
        }

        public int Sprint
        {
            get { return sprint; }
            set
            {
                if (value < 0 || value > 100)
                {
                    ThrowError("Sprint");
                }
                this.sprint = value;
            }
        }

        public int Dribble
        {
            get { return dribble; }
            set
            {
                if (value < 0 || value > 100)
                {
                    ThrowError("Dribble");
                }
                this.dribble = value;
            }
        }

        public int Passing
        {
            get { return passing; }
            set
            {
                if (value < 0 || value > 100)
                {
                    ThrowError("Passing");
                }
                this.passing = value;
            }
        }

        public int Shooting
        {
            get { return shooting; }
            set
            {
                if (value < 0 || value > 100)
                {
                    ThrowError("Shooting");
                }
                this.shooting = value;
            }
        }

        public void ThrowError(string name)
        {
            throw new ArgumentException($"{name} should be between 0 and 100.");
        }

        public int Average()
        {
            return (this.endurance + this.sprint + this.dribble + this.passing + this.shooting) / 5;
        }
    }
}
