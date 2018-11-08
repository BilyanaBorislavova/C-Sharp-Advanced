using System;
using System.Collections.Generic;
using System.Text;


    public class EarthMonument : Monument
    {
        private int earthAffinity;

        public int EarthAffinity
        {
            get { return earthAffinity; }
            set { earthAffinity = value; }
        }

        public EarthMonument(string name, int earthAffinity) : base(name)
        {
            this.EarthAffinity = earthAffinity;
        }

    public override string ToString()
    {
        return $"###Earth Monument: {this.Name}, Earth Affinity: {this.EarthAffinity}";
    }
}

