using System;

namespace _04.Hotel
{
    class hotel
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            var priceStudio = 0.0;
            var priceDouble = 0.0;
            var priceSuite = 0.0;

            if (month == "May" || month == "October")
            {
                priceStudio = nights * 50;
                priceDouble = nights * 65;
                priceSuite = nights * 75;
            }
            else if (month == "June" || month == "September")
            {
                priceStudio = nights * 60;
                priceDouble = nights * 72;
                priceSuite = nights * 82;
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                priceStudio = nights * 68;
                priceDouble = nights * 77;
                priceSuite = nights * 89;
            }

            if ((nights > 7) && (month == "May" || month == "October"))
            {
                if (month == "October")
                {
                    priceStudio = (nights - 1) * 50;
                }

                priceStudio *= 0.95;
            }
            else if ((nights > 14) && (month == "June" || month == "September"))
            {
                priceDouble = (nights * 72) * 0.9;
            }
            else if ((nights > 14) && (month == "July" || month == "August" || month == "December"))
            {
                priceSuite = (nights * 89) * 0.85;
            }
            else if ((nights > 7) && (month == "September"))
            {
                priceStudio = (nights - 1) * 60;
            }

            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
            Console.WriteLine($"Double: {priceDouble:F2} lv.");
            Console.WriteLine($"Suite: {priceSuite:F2} lv.");
        }
    }
}
