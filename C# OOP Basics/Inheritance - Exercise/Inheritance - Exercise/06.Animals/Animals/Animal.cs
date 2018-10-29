using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Animals
{
    public class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get => this.name;
            set
            {
                Validator(value);
                this.name = value;
            }
        }

        public int Age
        {
            get => this.age;
            set
            {
                Validator(value.ToString());
                if(value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.age = value;
            }
        }

        public string Gender
        {
            get => this.gender;
            set
            {
                Validator(value);
                this.gender = value;
            }
        }

      
        public void Validator(string value)
        {
            if (value == "" || value == " " || value == null)
            {
                throw new Exception("Invalid input!");
            }
        }

        public virtual string ProduceSound()
        {
            return "";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}\n{this.Name} {this.Age} {this.Gender}\n{this.ProduceSound()}";
        }
    }


}
