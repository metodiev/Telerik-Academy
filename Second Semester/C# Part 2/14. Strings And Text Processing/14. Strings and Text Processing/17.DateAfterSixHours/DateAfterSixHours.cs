using System;
using System.Globalization;
//Write a program that reads a date and time given in the format: day.month.year hour:minute:second
//and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day 
//of week in Bulgarian.


class DateAfterSixHours
{
    static void Main()
    {
        string first = "27.02.2006 12:55:46";
      
        string format = "dd.MM.yyyy HH:mm:ss";
        DateTime firstDate = DateTime.ParseExact(first, format, CultureInfo.InvariantCulture);
      
        firstDate = firstDate.AddHours(6.5);

        Console.WriteLine(firstDate);
       
    }
}

