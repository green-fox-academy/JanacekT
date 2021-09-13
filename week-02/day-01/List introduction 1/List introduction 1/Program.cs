using System;
using System.Collections.Generic;

namespace List_introduction_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an empty list which will contain names (strings)
            //Print out the number of elements in the list

            List<string> names = new List<string>(5);
            Console.WriteLine(names.Count);

            //Add "William" to the list
            //Print out whether the list is empty or not

            names.Add("William");
            Console.WriteLine(names.Count);

            //Add "John" to the list
            //Add "Amanda" to the list
            //print out the 3rd element

            names.Add("John");
            names.Add("Amanda");
            Console.WriteLine(names.Count);
            Console.WriteLine(names[2]);

            //Iterate through the list and print out each name

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            //Iterate through the list and print

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{i + 1}." + $"{names[i]}");
            }

            //Remove the 2nd element
            //Iterate through the list in a reversed order and print out each name

            names.RemoveAt(1);

            names.Reverse();

            foreach (string a in names)
            {
                Console.WriteLine(a);
            }

            names.Clear();






        }
    }
}
