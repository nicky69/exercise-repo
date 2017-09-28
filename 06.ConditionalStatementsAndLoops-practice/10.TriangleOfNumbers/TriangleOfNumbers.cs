using System;

namespace _10.TriangleOfNumbers
{
    class TriangleOfNumbers
    {
        static void Main(string[] args)
        {
             var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}
