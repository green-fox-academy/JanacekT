using System;

namespace DoubleItems
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array

            int[] numbers = { 3, 4, 5, 6, 7 };

            int a = Convert.ToInt32(numbers[0]) * 2;
            int b = Convert.ToInt32(numbers[1]) * 2;
            int c = Convert.ToInt32(numbers[2]) * 2;
            int d = Convert.ToInt32(numbers[3]) * 2;
            int e = Convert.ToInt32(numbers[4]) * 2;

            Console.WriteLine("{0} {1} {2} {3} {4}" ,a,b,c,d,e);




            Console.ReadLine();
        }
    }
}
