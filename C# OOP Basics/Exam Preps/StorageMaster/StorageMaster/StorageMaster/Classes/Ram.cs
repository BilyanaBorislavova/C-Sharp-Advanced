using StorageMaster.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Classes
{
    class Ram : Product
    {
        public Ram(double price) 
            : base(price, 0.1)
        {
            this.Price = price;
        }
    }
}
