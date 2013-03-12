using System;
using System.Globalization;
//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. Example:
//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2004
//Distance: 4 days


class NumberOfDays
{
    static void Main()
    {
        string first = "27.02.2006";
        string second = " 3.03.2004";

        string format = "dd.MM.yyyy";
        DateTime firstDate = DateTime.ParseExact(first, format, CultureInfo.InvariantCulture);

        DateTime secondDate = DateTime.ParseExact(first, format, CultureInfo.InvariantCulture);
        

        Console.WriteLine((secondDate - firstDate).TotalDays);
    }
}

