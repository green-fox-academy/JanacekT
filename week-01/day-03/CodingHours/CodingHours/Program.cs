using System;

namespace CodingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays
            double hoursDaily = 6;
            double semestrWeeks = 17;
            double workdays = 5;

            Console.WriteLine(hoursDaily * workdays * semestrWeeks);


            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52

            double averagehours = 52;

            double percentageOfCodingHours = (100 / averagehours) * (hoursDaily * workdays);

            Console.WriteLine(percentageOfCodingHours);
            



            


        }
    }
}
