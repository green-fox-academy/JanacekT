﻿using System;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `animals`
            //   with the following content:
            //   `["koal", "pand", "zebr", "anacond", "bo", "chinchill", "cobr", "gorill",
            //     "hyen", "hydr", "iguan", "impal", "pum", "tarantul", "pirahn"]`
            //
            // - Add all elements an `"a"` at the end

            string[] animals = { "koal", "pand", "zebr", "anacond", "bo", "chinchill", "cobr", "gorill", "hyen", "hydr", "iguan", "impal", "pum", "tarantul", "pirahn" };

            for (int i = 0; i < 15; i++)
            {
                animals[i] = ({ animals} + "a");
            }
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(animals[i]);
            }
            
        }
    }
}
