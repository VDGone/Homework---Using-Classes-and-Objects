using System;

namespace _03.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            //Write a program that prints to the console which day of the week is today.
            //Use System.DateTime.

            DateTime dayOfWeek = DateTime.Today;
            Console.WriteLine("Today is {0}!", dayOfWeek.DayOfWeek);
        }
    }
}
