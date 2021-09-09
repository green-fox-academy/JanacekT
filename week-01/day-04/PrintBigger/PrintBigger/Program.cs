using System;

namespace PrintBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one

            Console.WriteLine("Hello you, please enter your number");

            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine(number1 + " is bigger than " + number2);
            }
            else if (number1 == number2)
            {
                Console.WriteLine(number1 + " = " + number2);
            }
            else
            {
                Console.WriteLine(number2 + " is bigger than " + number1);
            }

            



        }
    }
}
