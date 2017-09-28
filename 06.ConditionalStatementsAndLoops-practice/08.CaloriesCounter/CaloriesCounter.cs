using System;


namespace _08.CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            var numberOfIngedients = int.Parse(Console.ReadLine());
            var totalCalories = 0;

             var cheese = 500;
             var tomatoSauce = 150;
             var salami = 600; 
             var pepper = 50;

            for (int i = 0; i < numberOfIngedients; i++)
            {
                var ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {
                    case "cheese": totalCalories += cheese;
                        break;
                    case "tomato sauce": totalCalories += tomatoSauce;
                        break;
                    case "salami": totalCalories += salami;
                        break;
                    case "pepper": totalCalories += pepper;
                        break;
                    default: continue;
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
