using System;

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

class BitIntegerToBinary
{
    static int p = 0;
    static Tuple<short, short> ChangeSign(short num)
    {
        short sign = 0;
        short mask = 1;
       
        if (num <=0)
        {
             num = (short)(num & (~(mask << 15)));
             p = num;    
        }

        else if (num > 0)
        {
            sign = (short)((num >> 15) & mask);
            num = (short)(num & (~(mask << 15)));
        }
        
        return new Tuple<short, short>(num, sign);
    }

    static void Main()
    {
        Console.WriteLine("Enter integer number between -32768 and 32767");
        short number = short.Parse(Console.ReadLine());
        short sign = 0;
        ChangeSign(number);
        var tuple = new Tuple<short, short>(number, sign);
        string binary = null;

        if (number > 0)
        {
            while (number > 0)
            {
                binary = (number % 2) + (binary);
                number /= 2;
            }
        }

        if (number < 0)
        {
            while (p > 0)
            {
                    binary = (p % 2) + (binary);
                    p /= 2;
                
            }
        }

        binary = sign + binary;
        Console.WriteLine(binary.PadLeft(15, '0'));
    }
}

