using MilitaryElite.Contracts;
using MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Classes
{
    public class Engineer : ISolider, IPrivate, ISpecialisedSolider
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public Corps corps { get; }
        public List<Repair> repairs { get; set; }
        public List<Mission> mission { get; set; }

        public Engineer(string id, string firstName, string lastName, decimal salary, Corps corps)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.corps = corps;
            this.repairs = new List<Repair>();
            this.mission = new List<Mission>();
        }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}\nCorps: {this.corps}\nRepairs:";
        }
    }
}
