using System;

/*
 * Create a console application that prints the current date and time.
 */

class PrintTheCurrentDateAndTime
{
    static void Main()
    {
        DateTime currentDateAndTime = DateTime.Now;
        string format = "ddd MMM d yyy HH:mm";
        Console.WriteLine(currentDateAndTime.ToString(format));  
    }
}

