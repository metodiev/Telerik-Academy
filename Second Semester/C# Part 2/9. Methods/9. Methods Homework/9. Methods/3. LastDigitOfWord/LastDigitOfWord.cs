using System;

//Write a method that returns the last digit of given integer as an English word. 
//Examples: 512  "two", 1024  "four", 12309  "nine".

class LastDigitOfWord
{
    static void ReturnLastDigitName(int number)
    {
        string numberCharachters = Convert.ToString(number);
        int lastDigit = numberCharachters.Length;
        int digit = numberCharachters[lastDigit-1];
        //Console.WriteLine(digit);
        switch (digit)
        {
            case 48: Console.WriteLine("zero");
                break;
            case 49: Console.WriteLine("one");
                break;
            case 50: Console.WriteLine("two");
                break;
            case 51: Console.WriteLine("three");
                break;
            case 52: Console.WriteLine("four");
                break;
            case 53: Console.WriteLine("five");
                break;
            case 54: Console.WriteLine("six");
                break;
            case 55: Console.WriteLine("seven");
                break;
            case 56: Console.WriteLine("eight");
                break;
            case 57: Console.WriteLine("nine");
                break;
            default:
                break;
        }

    }

    static void Main()
    {
        Console.WriteLine("Enter integer number:");
        int number = int.Parse(Console.ReadLine());
        ReturnLastDigitName(number);
    }
}

