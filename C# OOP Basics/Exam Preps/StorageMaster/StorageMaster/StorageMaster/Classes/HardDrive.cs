using StorageMaster.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Classes
{
    class HardDrive : Product
    {
        public HardDrive(double price) 
            : base(price, 1)
        {
            this.Price = price;
        }
    }
}
