using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carsLot = new HashSet<string>();

            string[] cmdArg = Console.ReadLine().Split(", ");

            while (cmdArg[0] != "END")
            {
                if (cmdArg[0] == "IN")
                {
                    carsLot.Add(cmdArg[1]);
                }
                else if (cmdArg[0] == "OUT")
                {
                    carsLot.Remove(cmdArg[1]);
                }

                cmdArg = Console.ReadLine().Split(", ");
            }

            if (carsLot.Count > 0)
            {
                foreach (var item in carsLot)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            
        }
    }
}
