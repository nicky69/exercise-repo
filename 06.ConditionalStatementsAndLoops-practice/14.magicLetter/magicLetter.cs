using System;


namespace _14.magicLetter
{
    class magicLetter
    {
        static void Main(string[] args)
        {
            var firsLetter = char.Parse(Console.ReadLine().ToLower());
            var secondLetter = char.Parse(Console.ReadLine().ToLower());
            var thirdLetter = char.Parse(Console.ReadLine().ToLower());


            for (int i = firsLetter; i <= secondLetter; i++)
            {
                for (int j = firsLetter; j <= secondLetter; j++)
                {
                    for (int p = firsLetter; p <= secondLetter; p++)
                    {
                        if (i != thirdLetter && j != thirdLetter && p != thirdLetter)
                        {
                            Console.Write($"{(char)i}{(char)j}{(char)p} ");
                        }

                    }
                }
            }
            Console.WriteLine();
        }
    }
}
