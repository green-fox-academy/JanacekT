using System;
using System.Collections.Generic;

namespace List_Introduction_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list ('List A') which contains the following values

            List<string> A = new List<string> { "Apple", "Avocado", "Blueberries", "Durian", "Lychee" };

            //Create a new list('List B') with the values of List A

            List<string> B = new List<string>(A);

            //Print out whether List A contains "Durian" or not

            int fruit = A.IndexOf("Durian");
            if (fruit > 0)
            {
                Console.WriteLine("Yes, there is a durian in list A");
            }
            else
            {
                Console.WriteLine("No, there is no durian in a list A");

            }

            // neco snazsiho?

            Console.WriteLine(A.Contains("Durian"));

            //Remove "Durian" from List B

            B.Remove("Durian");

            //Add "Kiwifruit" to List A after the 4th element

            A.Insert(3, "Kiwifruit");

            //Compare the size of List A and List B

            if (A.Count == B.Count)
            {
                Console.WriteLine("A = B");
            }
            else if (A.Count < B.Count)
            {
                Console.WriteLine("B is bigger than A");
            }
            else
            {
                Console.WriteLine("A is bigger than B");
            }

            //Get the index of "Avocado" from List A

            Console.WriteLine(A.IndexOf("Avocado"));

            //Get the index of "Durian" from List B

            Console.WriteLine(B.IndexOf("Durian"));

            //Add "Passion Fruit" and "Pomelo" to List B in a single statement

            B.AddRange("Passion Fruit, Pomelo".Split(","));

            //Print out the 3rd element from List A

            Console.WriteLine(A[2]);


        }
    }
}
