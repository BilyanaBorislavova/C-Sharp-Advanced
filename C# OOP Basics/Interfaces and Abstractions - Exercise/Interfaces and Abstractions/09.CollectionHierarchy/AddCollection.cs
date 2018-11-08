using CollectionHierarchy.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionHierarchy
{
    public class AddCollection : IAdd, IMyList
    {
        public List<string> Collection { get; set; }

        public AddCollection()
        {
            this.Collection = new List<string>();
        }

        public void Add(string element)
        {
            this.Collection.Add(element);
            Console.Write(this.Collection.IndexOf(element) + " ");
        }
    }
}
