using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public interface IVehicle
    {
        double fuelQuantity { get; set; }
        double fuelConsumption { get; set; }
    }
}
