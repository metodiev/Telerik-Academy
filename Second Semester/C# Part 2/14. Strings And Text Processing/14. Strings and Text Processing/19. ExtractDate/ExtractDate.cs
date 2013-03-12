using System;
using System.Text;
using System.Globalization;

//Write a program that extracts from a given text all dates that match
//the format DD.MM.YYYY. Display them in the standard date format for Canada.
//[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss]

class ExtractDate
{
    static void Main()
    {
        string stringDate = "11.09.2001 12:54:16";

        string format = "dd.MM.yyyy HH:mm:ss";
        DateTime date = DateTime.ParseExact(stringDate, format, CultureInfo.InvariantCulture);

        Console.WriteLine("Year: {0}\nMonth: {1}\nDay: {2}\nHour: {3}\nSecond: {4}",
        date.Year, date.Month, date.Day, date.Hour, date.Second);

    }
}

