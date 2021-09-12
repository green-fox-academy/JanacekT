using System;

namespace Cuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            double a = 6;
            double b = 10;
            double c = 15;

            double surface = 2*((a * b) + (b * c) + (a * c) );
            double volume = a * b * c;

            Console.WriteLine("Surface Area: " +surface);
            Console.WriteLine("Volume: " + volume);

        }
    }
}
