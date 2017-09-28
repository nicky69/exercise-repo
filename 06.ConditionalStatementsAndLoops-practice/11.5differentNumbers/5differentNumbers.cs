﻿using System;
using System.Diagnostics.Contracts;

namespace _11._5differentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
           var secondNumber = int.Parse(Console.ReadLine());

            if (Math.Abs(secondNumber - firstNumber) < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int one = firstNumber; one <= secondNumber; one++)
                {
                    for (int two = one + 1; two <= secondNumber; two++)
                    {
                        for (int three = two + 1; three <= secondNumber; three++)
                        {
                            for (int four = three +1; four <= secondNumber ; four++)
                            {
                                for (int five = four + 1; five <= secondNumber; five++)
                                {
                                    if (one < two || two < three || three < four || four < five)
                                    {
                                        Console.WriteLine($"{one} {two} {three} {four} {five}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
