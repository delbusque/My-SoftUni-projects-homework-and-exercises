using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class Car
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string manufacturer, string model, int year)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
        }

        public Car(string manufacturer, string model)
        {
            Manufacturer = manufacturer;
        }

        public override string ToString()
        {
            return $"{Manufacturer} {Model} ({Year})";
        }
    }

}
