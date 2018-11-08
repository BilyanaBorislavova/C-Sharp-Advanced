using CollectionHierarchy.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class AddRemoveCollection : IMyList, IAddRemove
    {
        public List<string> Collection { get; set; }

        public AddRemoveCollection()
        {
            this.Collection = new List<string>();
        }

        public void Add(string element)
        {
            this.Collection.Add(element);
            Console.Write(this.Collection.IndexOf(element) + " ");
        }

        public string Remove(string element)
        {
           if(this.Collection.Contains(element))
            {
                this.Collection.Remove(element);
            }

            return element;
        }
    }
}
