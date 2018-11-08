using System;
using System.Collections.Generic;
using System.Text;


    public class AirMonument : Monument
    {
        private int airAffinity;

        public int AirAffinity
        {
            get { return airAffinity; }
            set { airAffinity = value; }
        }

        public AirMonument(string name, int airAffinity) : base(name)
        {
            this.AirAffinity = airAffinity;
        }

    public override string ToString()
    {
        return $"###Air Monument: {this.Name}, Air Affinity: {this.AirAffinity}";
    }
}

