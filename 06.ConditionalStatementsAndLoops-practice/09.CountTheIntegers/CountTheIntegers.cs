using System;
namespace _09.CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var num = 0;
            var count = 0;

            while (int.TryParse(input, out num))
            {
                input = Console.ReadLine();
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
