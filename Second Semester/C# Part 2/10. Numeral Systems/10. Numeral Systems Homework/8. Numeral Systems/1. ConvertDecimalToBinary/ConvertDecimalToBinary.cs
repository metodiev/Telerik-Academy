using System;

//Write a program to convert decimal numbers to their binary representation.

class ConvertDecimalToBinary
{
    static void DecimalToBinary(int num)
    {
        int temp;
        string binary = null;

        while (num > 0)
        {
            temp = num % 2;
            num /= 2;
            binary = temp.ToString() + binary;
        }

        Console.WriteLine(binary);
    }

    static void Main()
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());

        DecimalToBinary(number);
    }
}

