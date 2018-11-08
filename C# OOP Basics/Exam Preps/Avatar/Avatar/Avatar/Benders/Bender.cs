using System;
using System.Collections.Generic;
using System.Text;


    public abstract class Bender
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int power;

        public int Power
        {
            get { return power; }
            set { power = value; }
        }

        public Bender(string name, int power)
        {
            this.Name = name;
            this.Power = power;
        }

}

