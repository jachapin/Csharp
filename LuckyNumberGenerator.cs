using System;
using System.Collections.Generic;

namespace LuckyNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*** Get user input */
            string intro = @"Lucky Number Generator
How many numbers do you want? 1-99";
            Console.WriteLine(intro);
            int input = int.Parse(Console.ReadLine());

            // Check that input is less than 100
            while (input > 99)
            {
                Console.WriteLine(@"Range limited from 1 - 99
How many numbers do you want?");
                input = int.Parse(Console.ReadLine());
            }

            /*** Create list of random numbers */
            List<int> numbers = new List<int>();

            Random rand = new Random();

            while (numbers.Count < input) 
            {
                int n = rand.Next(1, 100);

                if (!numbers.Contains(n))
                {
                    numbers.Add(n);
                }
               
            }

            numbers.Sort();

            /*** Print Numbers */
            foreach (var n in numbers)
            {
                // Print with format string: five spaces between numbers
                Console.Write("{0,5}", n);
            }

        }
    }
}
