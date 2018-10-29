﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Animals
{
    public class Kittens : Cat
    {
        public Kittens(string name, int age)
            : base(name, age, "Female")
        {
         
        }

        public override string ProduceSound()
        {
            return "Meow!";
        }
    }
}
