using System;
using System.Collections.Generic;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();
            HashSet<string> vipGuests = new HashSet<string>();

            string reservations = Console.ReadLine();


            while (reservations != "PARTY")
            {
                if (reservations[0] > 47 && reservations[0] < 58)
                {
                    vipGuests.Add(reservations);
                }
                else
                {
                    guests.Add(reservations);
                }

                reservations = Console.ReadLine();
            }

            string usedReservations = Console.ReadLine();
            
            while (usedReservations != "END")
            {
                if (guests.Contains(usedReservations))
                {
                    guests.Remove(usedReservations);
                }
                else
                {
                    vipGuests.Remove(usedReservations);
                }

                usedReservations = Console.ReadLine();
            }

            Console.WriteLine(guests.Count + vipGuests.Count);

            foreach (var item in vipGuests)
            {
                Console.WriteLine(item);
            }

            foreach (var item in guests)
            {
                Console.WriteLine(item);
            }
        }
    }
}
