using System;

namespace AnimalsAndLegs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have

            Console.WriteLine("Dear User, how many chicken has the farmer?");
            string chickenString = Console.ReadLine();
            int chickens = Convert.ToInt32(chickenString);

            Console.WriteLine("Dear User, how many pigs has the farmer?");
            string pigsString = Console.ReadLine();
            int pigs = Convert.ToInt32(pigsString);

            int legs = ((chickens * 2) + (pigs * 4));

            Console.WriteLine(legs);


        }
    }
}
