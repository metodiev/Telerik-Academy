using System;

class HowOldYouWillBeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Enter your age");
        int age = int.Parse(Console.ReadLine());
        int afterTenYears = age + 10;
        Console.WriteLine("After ten years you will be: " + afterTenYears + " years old");
    }
}

