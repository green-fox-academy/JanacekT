using System;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `orders`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `orders`

            string[] orders = new string[] { "first", "second", "third" };

            string temporaryOrder = orders[0];
            orders[0] = orders[2];
            orders[2] = temporaryOrder;

            //does it work?

            Console.WriteLine(orders[2]);

            //yup

            Console.ReadLine();
        }
    }
}
