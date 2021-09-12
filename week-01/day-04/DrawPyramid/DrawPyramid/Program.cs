using System;

namespace DrawPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was

            Console.WriteLine("User, how many lines should the pyramid have?");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int lines = 0; lines <= a; ++lines)
            {
                for (int b = 0; b < a - lines; b++)
                {
                    Console.Write(" ");
                }
                for (int c = 0; c < 2*lines-1; c++)
                {
                    Console.Write("*");

                }

                Console.WriteLine();
            }

        }
    }
}
