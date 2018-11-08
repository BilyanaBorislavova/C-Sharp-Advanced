using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Classes
{
    public class Spy : ISpy, ISolider
    {
        public int CodeNumber { get; set; }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Spy(string id, string firstName, string lastName, int codeNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
            this.CodeNumber = codeNumber;
        }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}\nCode Number: {this.CodeNumber}";
        }
    }
}
