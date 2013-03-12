using System;
using System.IO;
using System.Text;
//* Write a program that shows the internal binary
//representation of given 32-bit signed floating-point 
//number in IEEE 754 format (the C# type float).
//Example: -27,25  sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.


class FloatToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter float number:");
        float number = float.Parse(Console.ReadLine());

        long  bb=BitConverter.(number);
        Console.WriteLine(bb);
        StringBuilder sb = new StringBuilder(raw.Length * 2);
        foreach (byte b in raw)
        {
            sb.Append(b.ToString("x"));
        }
        Console.WriteLine(sb);
    }
}

