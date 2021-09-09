using System;

namespace AverageOfInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("Dear User, I would like to ask you for five numbers. After each number press Enter");

            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            double c = Convert.ToInt32(Console.ReadLine());
            double d = Convert.ToInt32(Console.ReadLine());
            double e = Convert.ToInt32(Console.ReadLine());

            double sum = (a + b + c + d + e);
            double average = (sum / 5);

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);

            
 

        }
    }
}
