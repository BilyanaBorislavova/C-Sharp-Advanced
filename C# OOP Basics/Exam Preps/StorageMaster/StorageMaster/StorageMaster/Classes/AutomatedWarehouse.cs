using StorageMaster.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Classes
{
    class AutomatedWarehouse : Storage
    {
        private static readonly Vehicle[] vehicles =
        {
            new Semi(), new Semi(), new Semi()
        };

        public AutomatedWarehouse(string name) : base(name, 1, 2, vehicles)
        {
            this.Name = name;
        }
    }
}
