using System;

namespace DrawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was

            Console.WriteLine("Dear Friend, please enter the number you wish and I will draw the triangle for you");

            int a = Convert.ToInt32(Console.ReadLine());
            

            for (int i = 1; i <= a; i++)
            {
              
                for (int b = 1; b<=i; b++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(" ");
            }


        }
    }
}
