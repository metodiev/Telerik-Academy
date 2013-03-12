using System;

class UnicodeVariables
{
    static void Main()
    {
        int number = 72;
        string hexValue = number.ToString("X");
        Console.WriteLine("Hexadecimal value of {0} is {1}", number, hexValue);

        char unicodenSymbol = (char)0x48;
        Console.WriteLine("Unicode symbol of number 72 is: {0}", unicodenSymbol);
    }
}
