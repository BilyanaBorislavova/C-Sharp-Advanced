using StorageMaster.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Classes
{
    class Warehouse : Storage
    {
        private static readonly Vehicle[] vehicles =
         {
            new Truck()
        };


        public Warehouse(string name) : base(name, 10, 10, vehicles)
        {
            this.Name = name;
        }
    }
}
