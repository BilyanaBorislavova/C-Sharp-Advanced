using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Pet : IName, IBirthdate
    {
        public string Name { get; set; }
        public string BirthDate { get; set; }

        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.BirthDate = birthdate;
        }
    }
}
