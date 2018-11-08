using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Entities
{
    abstract class Vehicle
    {
        private int capacity;
        private readonly List<Product> trunk;
        private bool isFull;
        private bool isEmpty;

        public Vehicle(int capacity)
        {
            this.Capacity = capacity;
        }

        public int Capacity
        {
            get => this.capacity;
            set { value = this.capacity; }
        }
        public IReadOnlyCollection<Product> Trunk => this.trunk.AsReadOnly();
        public bool IsFull
        {
            get => this.isFull;
            set
            {
                double sum = 0;
                foreach (var item in trunk)
                {
                    sum += item.Weight;
                }

                if (sum >= capacity)
                {
                    value = true;
                }
                value =  false;
            }
        }
        public bool IsEmpty
        {
            get => this.isEmpty;
            set
            {
                if(this.Trunk.Count == 0)
                {
                    value = true;
                }
                value = false;
            }
        }

        public void LoadProduct(Product product)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }
            this.trunk.Add(product);
        }

        public Product Unload()
        {
            if (this.IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }
            var product = this.trunk.ElementAt(this.trunk.Count - 1);
            this.trunk.RemoveAt(this.trunk.Count - 1);
            return product;
        } 

    }
}
