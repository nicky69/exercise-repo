using System;

namespace _06.IntervalOfNumbers
{
    class IntervalOfNumbers
    {
        static void Main(string[] args)
        {
             var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            var startNumber = Math.Min(firstNumber, secondNumber);
            var endNumber = Math.Max(firstNumber, secondNumber);

            for (var i = startNumber; i <= endNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
