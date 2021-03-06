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

            int variable = 20;
            int[,] matrix = new int[variable, variable];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(0); column++)
                {
                    if (row == column)
                    {
                        matrix[row, column] = 1;

                    }
                    Console.Write(matrix[row, column]);
                }
                Console.WriteLine();
            }
           
            

        }
    }
}
