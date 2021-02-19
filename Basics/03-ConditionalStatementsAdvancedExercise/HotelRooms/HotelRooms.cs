using System;

namespace HotelRooms
{
    class HotelRooms
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double roomPriceStudio = 0;
            double roomPriceApartment = 0;
            double StudioFullPrice = 0;
            double ApartmentFullPrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    roomPriceStudio = 50.00;
                    roomPriceApartment = 65.00;
                    
                    StudioFullPrice = roomPriceStudio * nights;
                    if (7 < nights && nights <= 14 )
                    {
                        StudioFullPrice *= 0.95;
                    }
                    else if (nights > 14)
                    {
                        StudioFullPrice *= 0.70;
                    }

                    ApartmentFullPrice = roomPriceApartment * nights;
                    if(nights > 14)
                    {
                        ApartmentFullPrice *= 0.90;
                    }
                        break;

                case "June":
                case "September":
                    roomPriceStudio = 75.20;
                    roomPriceApartment = 68.70;

                    StudioFullPrice = roomPriceStudio * nights;
                    if (nights > 14)
                    {
                        StudioFullPrice *= 0.80;
                    }             

                    ApartmentFullPrice = roomPriceApartment * nights;
                    if (nights > 14)
                    {
                        ApartmentFullPrice *= 0.90;
                    }
                    break;

                case "July":
                case "August":
                    roomPriceStudio = 76.00;
                    roomPriceApartment = 77.00;

                    StudioFullPrice = roomPriceStudio * nights;

                    ApartmentFullPrice = roomPriceApartment * nights;
                    if (nights > 14)
                    {
                        ApartmentFullPrice *= 0.90;
                    }
                    break;
            }

            Console.WriteLine($"Apartment: {ApartmentFullPrice:f2} lv.");
            Console.WriteLine($"Studio: {StudioFullPrice:f2} lv.");
        }
    }
}
