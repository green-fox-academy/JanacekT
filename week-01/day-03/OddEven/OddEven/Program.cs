using System;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input,
            // then prints "Odd" if the number is odd, or "Even" if it is even.

            Console.WriteLine("Dear User, please write number of your choice.");

            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("This number is even");   
            }

            else
            {
                Console.WriteLine("This number is odd");
            }

        }
    }
}
