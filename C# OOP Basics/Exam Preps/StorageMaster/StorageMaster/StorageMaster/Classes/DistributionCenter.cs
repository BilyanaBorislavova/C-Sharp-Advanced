using StorageMaster.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Classes
{
    class DistributionCenter : Storage
    {
        private static readonly Vehicle[] vehicles =
        {
            new Van(), new Van(), new Van()
        };

        public DistributionCenter(string name) : base(name, 2, 5, vehicles)
        {
            this.Name = name;
        }
    }
}
