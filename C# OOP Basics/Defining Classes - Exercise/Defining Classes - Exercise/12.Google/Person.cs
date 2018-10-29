using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Person
    {
        private string name;
        private Company company;
        private Car car;
        private List<Parents> parents;
        private List<Children> children;
        private List<Pokemon> pokemons;

        public Person(string namey)
        {
            this.Name = name;
            this.Parents = new List<Parents>();
            this.Children = new List<Children>();
            this.Pokemons = new List<Pokemon>();
        }

        public Person(string name, Company company) : this(name)
        {
            this.Company = company;
        }

        public Person(string name, Car car) : this(name)
        {
            this.Car = car;
        }

        public Person(string name, List<Parents> parents) : this(name)
        {
            this.Parents = parents;
        }

        public Person(string name, List<Children> children) : this(name)
        {
            this.Children = children;
        }

        public Person(string name, List<Pokemon> pokemons) : this(name)
        {
            this.Pokemons = pokemons;
        }

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }

        public List<Children> Children
        {
            get { return children; }
            set { children = value; }
        }
        
        public List<Parents> Parents
        {
            get { return parents; }
            set { parents = value; }
        }

        public Company Company
        {
            get { return company; }
            set { company = value; }
        }

        public Car Car
        {
            get { return car; }
            set { car = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
