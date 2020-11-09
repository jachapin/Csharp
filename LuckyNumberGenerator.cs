using System;

namespace LuckyNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string intro = @"Lucky Number Generator
How many numbers do you want?";
            Console.WriteLine(intro);
            int input = int.Parse(Console.ReadLine());

            Random rand = new Random();

            for (int i = 0; i < input; i++)
            {
                // Print with format string: five spaces and number type with zero decimal points
                Console.Write("{0,5:N0}", rand.Next(1, 100));
            }

        }
    }
}
