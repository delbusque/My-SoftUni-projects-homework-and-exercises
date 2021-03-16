using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double litersPerKm, double airConParam) 
            : base(fuelQuantity, litersPerKm, airConParam)
        {
        }
    }
}
