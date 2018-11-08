using StorageMaster.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Classes
{
    class SolidStateDrive : Product
    {
        public SolidStateDrive(double price) 
            : base(price, 0.2)
        {
            this.Price = price;
        }
    }
}
