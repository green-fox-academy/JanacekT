using System;

namespace SumElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[54, 23, 66, 12]`
            // - Print the sum of the second and the third element

            int[] numbers = { 54, 23, 66, 12 };
            int i = Convert.ToInt32(numbers[1]);
            int j = Convert.ToInt32(numbers[2]);

            Console.WriteLine(i + j);
        }
    }
}
