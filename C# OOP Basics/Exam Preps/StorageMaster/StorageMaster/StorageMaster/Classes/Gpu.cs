using StorageMaster.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Classes
{
    class Gpu : Product
    {
        public Gpu(double price)
            : base(price, 0.7)
        {
            this.Price = price;
        }
    }
}
