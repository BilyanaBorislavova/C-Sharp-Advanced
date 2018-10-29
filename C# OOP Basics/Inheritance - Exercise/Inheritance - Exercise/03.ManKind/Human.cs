using System;
using System.Collections.Generic;
using System.Text;

namespace ManKind
{
    public class Human
    {
        private string firstName;
        private string secondName;

        public Human(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if(value[0].ToString() != value[0].ToString().ToUpper())
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }

                if(value.Length <= 3)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }

                this.firstName = value;
            }
        }

        public string SecondName
        {
            get { return this.secondName; }
            set
            {
                if (value[0].ToString() != value[0].ToString().ToUpper())
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }

                if(value.Length <= 2)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }

                this.secondName = value;
            }
        }
    }
}
