using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities
{
    abstract class Storage
    {
        private string name;
        private int capacity;
        private int garageSlots;
        private bool isFull;
        private readonly List<Vehicle> garage;
        private readonly List<Product> products;

        public Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;
            this.Garage = new List<Vehicle>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int GarageSlots { get; set; }
        public bool IsFull
        {
            get => this.isFull;
            set
            {
                double sum = 0;
                foreach (var item in products)
                {
                    sum += item.Weight;
                }

                if (sum >= capacity)
                {
                    value = true;
                }
                value = false;
            }
        }
        public IReadOnlyCollection<Vehicle> Garage { get; set; }
        public IReadOnlyCollection<Product> Products { get; set; }

        public Vehicle GetVehicle(int garageSlot)
        {
            if(garageSlot >= this.GarageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }
           
            if(this.garage[garageSlot] == null)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }

            return this.garage[garageSlot];
        }
       
        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            if (garageSlot >= this.GarageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }
            return 0;
        }
       
        public int UnloadVehicle(int garageSlots)
        {
            return 0;
        }
    }
}
