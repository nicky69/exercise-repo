using System;


namespace _03.RestaurantDiscount
{
    class restaurantDiscount
    {
        static void Main(string[] args)
        {
            var groupOfSize = int.Parse(Console.ReadLine());
            var typeOfPackage = Console.ReadLine();

            var pricePlace = 0.0;
            var pricePackage = 0.0;
            var place = "";
            var discount = 0.0;
            if (groupOfSize <= 50)
            {
                place = "Small Hall";
                pricePlace = 2500.00;
            }
            else if (groupOfSize <= 100)
            {
                place = "Terrace";
                pricePlace = 5000.00;
            }
            else if (groupOfSize <= 120)
            {
                place = "Great Hall";
                pricePlace = 7500.00;
            }

            if (typeOfPackage == "Normal")
            {
                pricePackage = 500;
                discount = 0.95;
            }
            else if (typeOfPackage == "Gold")
            {
                pricePackage = 750;
                discount = 0.9;
            }
            else if (typeOfPackage == "Platinum")
            {
                pricePackage = 1000;
                discount = 0.85;
            }
            var totalPrice = (pricePlace + pricePackage) * discount;
            var pricePerson = (totalPrice / groupOfSize);

            if (groupOfSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine($"We can offer you the {place}");
                Console.WriteLine($"The price per person is {pricePerson:F2}$");
            }

        }
    }
}
