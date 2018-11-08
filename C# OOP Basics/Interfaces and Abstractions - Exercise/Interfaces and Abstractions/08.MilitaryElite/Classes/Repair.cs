using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Classes
{
    public class Repair : IRepair
    {
        public string Name { get; set; }
        public string HoursWorked { get; set; }

        public Repair(string name, string hours)
        {
            this.Name = name;
            this.HoursWorked = hours;
        }
    }
}
