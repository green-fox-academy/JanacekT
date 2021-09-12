using System;

namespace MiletoKmCOnverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User, type the distance in miles ");

            
            double distance = Convert.ToDouble(Console.ReadLine());
            double km = distance * 1.609344;
            Console.WriteLine(km);




        }
    }
}
