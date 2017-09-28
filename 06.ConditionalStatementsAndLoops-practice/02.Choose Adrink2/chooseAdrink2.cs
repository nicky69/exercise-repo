using System;

namespace _02.Choose_Adrink2
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine().ToLower();
            var quantity = int.Parse(Console.ReadLine());
         
            switch (profession)
            {
                case "Athlete":
                    Console.WriteLine($"The {profession} has to pay {quantity * 0.70:f2}.");  
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine($"The {profession} has to pay {quantity * 1.00:f2}.");               
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The {profession} has to pay {quantity * 1.70:f2}.");  
                    break;
                default:
                    Console.WriteLine($"The {profession} has to pay {quantity * 1.20:f2}.");
                    break;
            }
        }
    }
}
