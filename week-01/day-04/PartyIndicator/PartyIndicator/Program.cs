using System;

namespace PartyIndicator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // The first number represents the number of girls that comes to a party, the
            // second represents the number of boys
            //
            // If the the number of girls and boys are equal and 20 or more people are coming to the party
            // it should print: The party is excellent!
            //
            // If there are 20 or more people coming to the party but the girl - boy ratio is not 1-1
            // it should print: Quite a cool party!
            //
            // If there are less people coming than 20
            // it should print: Average party...
            //
            // If no girls are coming, regardless the count of the people
            // it should print: Sausage party

            Console.WriteLine("Please enter number of girls coming to the party?");
            int girls = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter number of boys coming to the party?");
            int boys = Convert.ToInt32(Console.ReadLine());

            int total = boys + girls;

            if (girls == 0)
            {
                Console.WriteLine("Sausage party");
            }

            else if ((total >= 20) && (boys == girls))
            {
                Console.WriteLine("The party is excellent!");
            }
            else if ((total >= 20) && (boys != girls))
            {
                Console.WriteLine("Quite a cool party!");
            }

            else if (total < 20)
            {
                Console.WriteLine("Average party...");
            }

            
            
                    


            


           



        }
    }
}
