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
            double workDays = 5;

            Console.WriteLine(hoursDaily * workDays * semestrWeeks);


            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52

            double workHoursWeekly = 52;

            double percentageOfCodingHours = ((hoursDaily * workDays) / workHoursWeekly) * 100;

            Console.WriteLine(percentageOfCodingHours);
            



            


        }
    }
}
