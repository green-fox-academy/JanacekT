using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a two dimensional array dynamically with the following content.
            //   Note that a two dimensional array is often called matrix if every
            //   internal array has the same length.
            //   Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            //   Its length should depend on a variable
            //  
            // - Print this two dimensional array to the output

            int i, j;

            int[,] matrix = new int[4, 4];

            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write(matrix[i, j]);
                }

            }
            for (i = 0; i < 4; i++)
            {
                Console.Write(" ");
                for (j = 0; j < 4; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                    
            }

            Console.ReadLine();
            
        }
    }
}
