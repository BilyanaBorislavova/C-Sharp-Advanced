using StorageMaster.Classes;
using StorageMaster.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster
{
    class StorageMaster
    {
        List<Product> products = new List<Product>();
        string[] productTypes = new string[] { "Gpu", "HardDrive", "Ram", "SolidStateDrive" };

        List<Storage> storages = new List<Storage>();
        string[] storageTypes = new string[] { "AutomatedWarehouse", "DistributionCenter", "Warehouse" };

        public string AddProduct(string type, double price)
        {
            if(!productTypes.Contains(type))
            {
                throw new InvalidOperationException("Invalid product type!");
            }
          
            if(type == productTypes[0])
            {
                Gpu gpu = new Gpu(price);
                products.Add(gpu);
            }
            else if(type == productTypes[1])
            {
                HardDrive hardDrive = new HardDrive(price);
                products.Add(hardDrive);
            }
            else if(type == productTypes[2])
            {
                Ram ram = new Ram(price);
                products.Add(ram);
            }
            else if(type != productTypes[3])
            {
                SolidStateDrive solid = new SolidStateDrive(price);
                products.Add(solid);
            }

            return $"Added {type} to pool";

        }

        public string RegisterStorage(string type, string name)
        {
            if (!storageTypes.Contains(type))
            {
                throw new InvalidOperationException("Invalid storage type!");
            }

            if(type == storageTypes[0])
            {
                AutomatedWarehouse automatedWarehouse = new AutomatedWarehouse(name);
                storages.Add(automatedWarehouse);
            }
            else if(type == storageTypes[1])
            {
                DistributionCenter distributionCenter = new DistributionCenter(name);
                storages.Add(distributionCenter);
            }
            else if(type == storageTypes[2])
            {
                Warehouse warehouse = new Warehouse(name);
                storages.Add(warehouse);
            }

            return $"Registered {name}";
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            var currentStorage =  storageTypes.Where(a => a == storageName).Take(garageSlot);
            return $"Selected {currentStorage.GetType().Name}";
         }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            throw new NotImplementedException();
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            throw new NotImplementedException();
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            throw new NotImplementedException();
        }

        public string GetStorageStatus(string storageName)
        {
            throw new NotImplementedException();
        }

        public string GetSummary()
        {
            throw new NotImplementedException();
        }

    }
}
