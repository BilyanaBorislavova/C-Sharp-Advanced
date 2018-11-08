using System;
using System.Collections.Generic;
using System.Text;


    public abstract class Monument
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Monument(string name)
        {
            this.Name = name;
        }

    }

