using System;
using System.Collections.Generic;
using System.Text;


    public class WaterMonument : Monument
    {
        private int waterAffinity;

        public int WaterAffinity
        {
            get { return waterAffinity; }
            set { waterAffinity = value; }
        }

        public WaterMonument(string name, int waterAffinity) : base(name)
        {
            this.WaterAffinity = waterAffinity;
        }

    public override string ToString()
    {
        return $"###Water Monument: {this.Name}, Water Affinity: {this.WaterAffinity}";
    }
}

