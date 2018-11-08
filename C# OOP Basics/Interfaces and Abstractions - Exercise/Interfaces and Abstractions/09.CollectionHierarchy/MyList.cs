using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using CollectionHierarchy.Contracts;

namespace CollectionHierarchy
{
    public class MyList : IMyList, IAddRemoveUsed
    {
        public List<string> Collection { get; set; }

        public MyList()
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
            if (this.Collection.Contains(element))
            {
                this.Collection.Remove(element);
            }

            return element;
        }

        public void Used()
        {
            
        }
    }

}
