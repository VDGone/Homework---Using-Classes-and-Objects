using System;

namespace _05.Workdays
{
    class WorkDays
    {
        static void Main(string[] args)
        {
            //Write a method that calculates the number of workdays between today and given date, passed as parameter.
            //Consider that workdays are all days from Monday to Friday 
            //except a fixed list of public holidays specified preliminary as array.

            Console.WriteLine("Working days = {0}",GetWorkDays(new DateTime(2015, 02, 19), new DateTime(2016, 01, 01)));
        }
        static DateTime[] holidays = { new DateTime(2015, 03, 02), new DateTime(2015, 03, 03), new DateTime(2015, 12, 24), 
                                       new DateTime(2015, 04, 10), new DateTime(2015, 04, 13), new DateTime(2015, 05, 01),
                                       new DateTime(2015, 05, 06), new DateTime(2015, 09, 21), new DateTime(2015, 09, 22),
                                       new DateTime(2015, 12, 24), new DateTime(2015, 12, 25), new DateTime(2015, 12, 31), 
                                       new DateTime(2016, 01, 01) };

        static int RemoveHolidays(DateTime start, DateTime end, int result)
        {
            foreach (DateTime holiday in holidays)
                if (start <= holiday && holiday <= end &&
                    !(holiday.DayOfWeek == DayOfWeek.Saturday || holiday.DayOfWeek == DayOfWeek.Sunday))
                {
                    result--;
                }
                return result;
        }

        static void NonWorkDays(ref DateTime start, ref DateTime end)
        {
            if (start.DayOfWeek == DayOfWeek.Saturday)
            {
                start = start.AddDays(2);
            }
            if (start.DayOfWeek == DayOfWeek.Sunday)
            {
                start = start.AddDays(1);
            }
            if (end.DayOfWeek == DayOfWeek.Saturday)
            {
                end = end.AddDays(-1);
            }
            if (end.DayOfWeek == DayOfWeek.Sunday)
            {
                end = end.AddDays(-2);
            }
        }

        static int GetWorkDays(DateTime start, DateTime end)
        {
            if (end < start)
            {
                return GetWorkDays(end, start);
            }
            NonWorkDays(ref start, ref end);
            int offset = (int)(end - start).TotalDays + 1;
            int result = offset / 7 * 5 + offset % 7;

            return RemoveHolidays(start, end, Math.Max(result, 0));
        }
    }
}

