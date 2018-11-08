using MilitaryElite.Contracts;
using MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Classes
{
    public class Mission : IMission
    {
        public string CodeName { get; set; }
        public States states { get; }

        public Mission(string codeName, States states)
        {
            this.CodeName = codeName;
            this.states = states;
        }
    }
}
