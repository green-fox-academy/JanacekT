using System;

namespace SumAll
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Print the sum of the elements of `numbers`

            int[] numbers = new int[] { 3, 4, 5, 6, 7};

            int sum = 0;
            Array.ForEach(numbers, i => sum += i);

            Console.WriteLine(sum);




            Console.ReadLine();
        }
    }
}
