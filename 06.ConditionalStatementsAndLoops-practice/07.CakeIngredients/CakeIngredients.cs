using System;


namespace _07.CakeIngredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            var ingredients = Console.ReadLine();
            var counter = 0;

            while (ingredients != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredients}.");
                ingredients = Console.ReadLine();
                counter++;
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
