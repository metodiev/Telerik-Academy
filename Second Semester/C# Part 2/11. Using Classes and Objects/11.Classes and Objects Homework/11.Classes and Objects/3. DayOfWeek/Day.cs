using System;

//Write a program that prints to the console which day of the week is today. Use System.DateTime.

namespace _3.DayOfWeek
{
    class Day
    {
        static void Main()
        {
            DateTime day = new DateTime();
            Console.WriteLine("Today is {0}", day.DayOfWeek);
        }
    }
}
