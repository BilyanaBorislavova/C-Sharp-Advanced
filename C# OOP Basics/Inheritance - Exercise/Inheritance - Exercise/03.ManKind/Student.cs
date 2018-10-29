using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ManKind
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string secondName, string facultyNumber)
            :base(firstName, secondName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                Regex regex = new Regex(@"^([A-Za-z0-9]+)$");

                if(value.Length < 5 || value.Length > 10 || !regex.IsMatch(value))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return $"First Name: {base.FirstName}\nLast Name: {base.SecondName}\nFaculty number: {this.FacultyNumber}";
        }
    }
}
