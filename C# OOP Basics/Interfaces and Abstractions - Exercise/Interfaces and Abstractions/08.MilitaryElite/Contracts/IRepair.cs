using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Contracts
{
    public interface IRepair
    {
        string Name { get; set; }
        string HoursWorked { get; set; }
    }
}
