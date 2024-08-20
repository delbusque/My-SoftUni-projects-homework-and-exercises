using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractKitchen
{
    public class Kitchen : IOrdarable, IMachinery
    {

        public Kitchen()
        {
            Machineries = new List<string>() { "oven", "pan" };

        }
        public List<string> Machineries 
        {   
            get; set; 
        }

        public void ListAllMachineries()
        {
            Machineries.ForEach(m=>Console.WriteLine(m));
        }

        public void OrderMeal(string name)
        {
            Console.WriteLine($"{name} ordered !");
        }
    }
}
