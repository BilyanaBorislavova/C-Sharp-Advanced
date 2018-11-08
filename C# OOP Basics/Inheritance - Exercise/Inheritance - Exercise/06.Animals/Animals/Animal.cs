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
                if(value.Length < 1)
                {
                   throw new ArgumentException("Invalid input!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get => this.age;
            set
            {
                
                if(value <= 0)
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
                if(value.ToLower() != "male" && value.ToLower() != "female")
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.gender = value;
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
