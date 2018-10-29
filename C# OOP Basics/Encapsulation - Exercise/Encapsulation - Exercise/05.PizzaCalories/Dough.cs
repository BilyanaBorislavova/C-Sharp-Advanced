using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    class Dough
    {
        private string flourType;
        private string bakingTechnique; 
        private double weight;

        private string FlourType
        {
            get => flourType;
            set
            {
                if(value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    InvalidException();
                }
                this.flourType = value;
            }
        }

        private string BakingTechnique
        {
            get => bakingTechnique;
             set
            {
                if(value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    InvalidException();
                }
                this.bakingTechnique = value;
            }
        }

        private double Weight
        {
            get => weight;
            set
            {
                if(value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        public Dough(string flourType, string backingTechique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = backingTechique;
            this.Weight = weight;
        }

        public void InvalidException()
        {
            throw new ArgumentException("Invalid type of dough.");
        }

        public string CalculateCalories()
        {
            this.weight *= 2;
            if (this.flourType.ToLower() == "white")
            {
                this.weight *= 1.5;
            }
            else if (this.flourType.ToLower() == "wholegrain")
            {
                this.weight *= 1.0;
            }

            if (this.bakingTechnique.ToLower() == "crispy")
            {
                this.weight *= 0.9;
            }
            else if (this.bakingTechnique.ToLower() == "chewy")
            {
                this.weight *= 1.1;
            }
            else if (this.bakingTechnique.ToLower() == "homemade")
            {
                this.weight *= 1.0;
            }

            string str = $"{this.weight:f2}";
            return str;
        }
    }
}
