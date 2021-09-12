using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[3, 4, 5, 6, 7]`
            int[] numbers = { 3, 4, 5, 6, 7 };


            // - Reverse the order of the elements of `numbers`
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int tempReverse = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = tempReverse;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // - Print the elements of the reversed `numbers`
        }
    }
}
