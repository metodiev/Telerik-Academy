using System;

//Write a method that reverses the digits of given decimal number. Example: 256  652

class ReverseDigits
{
    static void ReverseNumber(decimal number)
    {
        string reverse = Convert.ToString(number);
        char[] reversedArray = reverse.ToCharArray();
        Array.Reverse(reversedArray);
        Console.WriteLine(reversedArray);
    }

    static void Main()
    {
        Console.WriteLine("Enter decimal number:");
        decimal number = decimal.Parse(Console.ReadLine());
        ReverseNumber(number);
    }
}

