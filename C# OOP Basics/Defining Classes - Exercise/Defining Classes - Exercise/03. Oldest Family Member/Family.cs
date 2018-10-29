﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class Family
    {
        private List<Person> people;

        public Family()
        {
            this.people = new List<Person>();
        }

        public void AddMember(Person person)
        {
            this.people.Add(person);
        }

        public Person GetOldestMember()
        {
            Person person = this.people.OrderByDescending(p => p.Age).FirstOrDefault();
            return person;
        }


    }

