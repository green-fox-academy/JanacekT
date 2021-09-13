using System;
using System.Collections.Generic;

namespace MapIntroduction1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create an empty map where the keys are integers and the values are characters

            Dictionary<string, string> map = new Dictionary<string, string>();

            //Print out whether the map is empty or not

            Console.WriteLine(map.Count);

            //Add the following key-value pairs to the map

            map.Add("97", "a");
            map.Add("98", "b");
            map.Add("99", "c");
            map.Add("65", "A");
            map.Add("66", "B");
            map.Add("67", "C");

            //Print all the keys

            Dictionary<string, string>.KeyCollection keys = map.Keys;
            foreach (string key in keys)
            {
                Console.WriteLine(key);
            }

            //Print all the values

            Dictionary<string, string>.ValueCollection values = map.Values;
            foreach (string val in values)
            {
                Console.WriteLine(val);
            }

            //Add value D with the key 68

            map.Add("68", "D");

            //Print how many key-value pairs are in the map

            Console.WriteLine(map.Count);

            //Print the value that is associated with key 99


            string result;
            if (map.TryGetValue("99", out result))
            {
                Console.WriteLine(result);
            }

            //Remove the key-value pair where with key 97

            map.Remove("97");

            string result1;
            if (map.TryGetValue("100", out result1))
            {
                Console.WriteLine("There is key 100");
            }
            else
            {
                Console.WriteLine("There is no key 100");
            }

            //Remove all the key-value pairs

            map.Clear();
        }
    }
}
