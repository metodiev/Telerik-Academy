//Write a method that calculates the number of workdays 
//between today and given date, passed as parameter. 
//Consider that workdays are all days from Monday to 
//Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Text;

namespace _5.NumberOfWorkdays
{
    class Workdays
    {
        static string RemoveSlash(string date)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < date.Length; i++)
            {
                if (date[i] != '/')
                sb.Append(date[i]);
            }
           
            return sb.ToString();
        }

        static void Main()
        {
            DateTime endTime = DateTime.Today;
            Console.WriteLine("enter date:\nFormat: yyy/mm/dd");
            string givenDate = "2013/01/22"; //Console.ReadLine();
      
            string str = RemoveSlash(givenDate);
            int day = Convert.ToInt32(str.Substring(6,2));
            int month = Convert.ToInt32(str.Substring(4, 2));
            int year = Convert.ToInt32(str.Substring(0,4));

            DateTime startTime = new DateTime(year, month, day);
            int endResult = 0;
            endResult = (endTime - startTime).Days;

            DateTime[] holidays =
            {
                new DateTime(2013, 9, 9),
                new DateTime(2005, 1, 1),
                new DateTime(2005, 3, 3),
                new DateTime(2005, 5, 1),
                new DateTime(2005, 6, 2),
                new DateTime(2005, 8, 6),
                new DateTime(2005, 9, 24),
                new DateTime(2010, 3, 3),
                
            };

           int count = 0;
           int workDays = 0;
           
            for (int i = 0; i < endResult; i++)
            {
                endTime = endTime.AddDays(1);
                if (endTime.DayOfWeek == DayOfWeek.Saturday || endTime.DayOfWeek == DayOfWeek.Sunday)
                {
                    count++;
                    foreach (var element in holidays)
                    {
                        if (element.DayOfYear == endTime.DayOfYear)
                        {
                            count++;
                        }
                    }
                }
            }

            workDays = endResult - count;
            Console.WriteLine(workDays);
        }
    }
}
