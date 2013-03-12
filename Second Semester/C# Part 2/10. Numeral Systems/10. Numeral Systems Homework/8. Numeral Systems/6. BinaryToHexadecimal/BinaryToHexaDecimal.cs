using System;
using System.Text;
//Write a program to convert binary numbers to hexadecimal numbers (directly).

class BinaryToHexaDecimal
{
    public static string BinaryStringToHexString(string binary)
    {
        int size = binary.Length;
        Console.WriteLine(""+((size / 8) + 1) * 8);
        StringBuilder result = new StringBuilder(size / 8 + 1);
        int mod4Len = size % 8;
        if (mod4Len != 0)
        {
            binary = binary.PadLeft(((size / 8) + 1) * 8, '0');
        }

        for (int i = 0; i < size; i += 8)
        {
            string bits = binary.Substring(i, 8);
            result.AppendFormat("{0:X2}", Convert.ToByte(bits, 2));
        }

        return result.ToString();
    }

    static void Main()
    {
        Console.WriteLine("Enter binary number");
        string binary = Console.ReadLine();
        string hexNumber = null;
        hexNumber = BinaryStringToHexString(binary);
        Console.WriteLine(hexNumber);   
    }
}

