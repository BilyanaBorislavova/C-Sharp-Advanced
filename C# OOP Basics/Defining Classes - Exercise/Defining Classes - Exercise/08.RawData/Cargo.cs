using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
   public class Cargo
    {
        private int cargoWeight;
        private string cargoType;

        public Cargo(int weight, string type)
        {
            this.CargoWeight = weight;
            this.CargoType = type;
        }

        public string CargoType
        {
            get { return cargoType; }
            set { cargoType = value; }
        }

        public int CargoWeight
        {
            get { return cargoWeight; }
            set { cargoWeight = value; }
        }

    }
}
