using System;

class CheckThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Enter integer number");
        int number;
        number = int.Parse(Console.ReadLine());

        int expression = (((number/100) % 10));
        Console.WriteLine("third digit (right to left) of numebr is {0}", expression);
    }
}

