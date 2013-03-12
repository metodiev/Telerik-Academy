using System;

class IntegerToHeximal
{
    static void Main()
    {
        int number = 254;
        string hexOutput = String.Format("{0:X}", number);
        Console.WriteLine("Hexadecimal value of {0} is {1}", number, hexOutput);
    }
}

