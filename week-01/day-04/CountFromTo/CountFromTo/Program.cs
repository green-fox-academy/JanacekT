using System;

namespace CountFromTo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5

            Console.WriteLine("Hello there, please enter first number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter second number and magic will start");
            int b = Convert.ToInt32(Console.ReadLine());
            

            if (b <= a)
            {
                Console.WriteLine("The second number should be bigger");
            }

            for (int i = a; i < b; i++)
            {
                Console.WriteLine(i);
            }


        }
    }
}
