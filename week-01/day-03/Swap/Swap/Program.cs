using System;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123, b = 526;
            (a, b) = (b, a);
         
            Console.WriteLine(a);
            Console.WriteLine(b);

           
        }
    }
}
