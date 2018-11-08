using System;
using System.Collections.Generic;
using System.Text;


    public class FireMonument : Monument
    {
        private int fireAffinity;

        public int FireAffinity
        {
            get { return fireAffinity; }
            set { fireAffinity = value; }
        }

        public FireMonument(string name, int fireAffinity) : base(name)
        {
            this.FireAffinity = fireAffinity;
        }

    public override string ToString()
    {
        return $"###Fire Monument: {this.Name}, Fire Affinity: {this.FireAffinity}";
    }
}

