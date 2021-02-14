using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {

        private List<Car> data;
        public string Type { get; set; }
        public int Capacity { get; set; }
        public int Count => data.Count; // public int Counter { get { return data.Count; } }
        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            data = new List<Car>();
        }

        public void Add(Car car)
        {
            if (data.Count < Capacity)
            {
                data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            Car carToRemove = data.FirstOrDefault
                (c => c.Manufacturer == manufacturer && c.Model == model);

            if (data.Contains(carToRemove))
            {
                data.Remove(carToRemove);
                return true;
            }
            return false;
        }

        public Car GetLatestCar()
        {
            Car latestCar = data.OrderByDescending(c => c.Year).FirstOrDefault();
            return latestCar;
        }

        public Car GetCar(string manufacturer, string model)
        {
            Car carToGet = data.FirstOrDefault(c => c.Manufacturer == manufacturer 
            && c.Model == model);
            return carToGet;
        }

        public string GetStatistics()
        {
            StringBuilder statistics = new StringBuilder();

            statistics.AppendLine($"The cars are parked in {Type}:");
            foreach (var car in data)
            {
                statistics.AppendLine(car.ToString());
            }
            string result = statistics.ToString();
            return result;
        }
    }
}
