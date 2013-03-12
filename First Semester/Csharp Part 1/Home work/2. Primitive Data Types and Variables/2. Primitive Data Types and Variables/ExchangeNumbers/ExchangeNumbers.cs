using System;

class ExchangeNumbers
{
    static void Main()
    {
        int firstNumber = 5;
        int secondNumber = 10;
        int exchange;
        Console.WriteLine("Before exchange numbers are:{0}, {1}", firstNumber, secondNumber);
        exchange = firstNumber;
        firstNumber = secondNumber;
        secondNumber = exchange;

        Console.WriteLine("After exchange numbers are {0} and {1}", firstNumber, secondNumber);
    }
}
