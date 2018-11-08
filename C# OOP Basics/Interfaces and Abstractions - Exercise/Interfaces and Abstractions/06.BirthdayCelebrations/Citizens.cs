using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Citizens : IId, IBirthdate, IName
    {
        private string name;
        private int age;

        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string BirthDate { get; set ; }

        public Citizens(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.BirthDate = birthdate;
        }
    }
}
