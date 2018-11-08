using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Core
{
    public class Engine
    {
        public void Run()
        {
            string[] elementsToAdd = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            foreach (var item in elementsToAdd)
            {
                addCollection.Add(item);
            }
            Console.WriteLine();
            foreach (var item in elementsToAdd)
            {
                addRemoveCollection.Add(item);
            }
            Console.WriteLine();
            foreach (var item in elementsToAdd)
            {
                myList.Add(item);
            }
            Console.WriteLine();
        }

    }
}
