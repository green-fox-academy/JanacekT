using System;
using System.Text;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText applying indentation

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            StringBuilder sb = new StringBuilder("- Buy milk\n");
            sb.Insert(0, "My todo:\n");
            sb.AppendLine("- Download games\n \t - Diablo");
            
           

            Console.WriteLine(sb.ToString());
        }
    }
}
