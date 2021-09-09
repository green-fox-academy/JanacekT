using System;

namespace MiletoKmCOnverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User, type the distance in miles ");

            string miles = Console.ReadLine();
            double distance = Convert.ToDouble(miles);
            double km = distance * 1.609344;
            Console.WriteLine(km);




        }
    }
}
