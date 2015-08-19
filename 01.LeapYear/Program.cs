using System;

namespace _01.LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            //Write a program that reads a year from the console and checks whether it is a leap one.
            //Use System.DateTime.

            Console.WriteLine("Enter year: ");
            int yearCheck = int.Parse(Console.ReadLine());
            
            if (DateTime.IsLeapYear(yearCheck))
            {
                Console.WriteLine("{0} is a leap year!", yearCheck);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year!", yearCheck);
            }
        }
    }
}
