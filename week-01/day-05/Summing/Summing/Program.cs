using System;

namespace Summing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function called `sum()` that returns the sum of numbers from zero to the given parameter

            Console.WriteLine("Please, enter a number");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Sum(input));
        }

        static int Sum(int num)
        {
            int result = 0;

            for (int i = 0; i <= num ; i++)
            {
                result += i;
            }

            return result;
        }
    }
}
