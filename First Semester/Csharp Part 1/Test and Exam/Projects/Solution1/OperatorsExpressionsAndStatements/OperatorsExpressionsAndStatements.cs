using System;

class Program
{
    static void Main()
    {
        int squarePerimeter = 17;
        double squareSide = squarePerimeter / 4.0;
        double squareArea = squareSide * squareSide;
        Console.WriteLine(squareSide); // 4.25
        Console.WriteLine(squareArea); // 18.0625
        int a = 5;
        int b = 4;
        Console.WriteLine(a + b); // 9
        Console.WriteLine(a + b++); // 9
        Console.WriteLine(a + b); // 10
        Console.WriteLine(a + (++b)); // 11
        Console.WriteLine(a + b); // 11

        Console.WriteLine(12 / 3); // 4
        Console.WriteLine(11 / 3); // 3


        Console.WriteLine(11.0 / 3); // 3.666666667
        Console.WriteLine(11 / 3.0); // 3.666666667
        Console.WriteLine(11 % 3);   // 2
        Console.WriteLine(11 % -3);  // 2
        Console.WriteLine(-11/-3.0);// -2
        Console.WriteLine(-15.00000000000000000 /- 3.0000000000000000000000);  //5

        Console.WriteLine(1.5 / 0.0);  // Infinity
        Console.WriteLine(0/1.5);       //0
        Console.WriteLine(-1.5 / 0.0); // -Infinity
        Console.WriteLine(0.0 / 0.0);  // NaN


        decimal p = 0;
        Console.WriteLine(p / 0); // DivideByZeroException
       // decimal p = 0;
        Console.WriteLine(5 / p); // DivideByZeroException
        int x = 0;
        Console.WriteLine(5 / x); // DivideByZeroException

       
 //
        int bigNum = 2000000000;
        int bigSum = 2 * bigNum; // Integer overflow!
        Console.WriteLine(bigSum); // -294967296

        bigNum = Int32.MaxValue;
        bigNum = bigNum + 1;
        Console.WriteLine(bigNum); // -2147483648

        checked
        {
            // This will cause OverflowException
            bigSum = bigNum * 2;
        }

        int intMax = Int32.MaxValue;
        float floatMAx = float.MaxValue;
        double doubleMax = double.MaxValue;
        long longMax = long.MaxValue;
        byte byteMax = byte.MaxValue;
        decimal decimalMax = decimal.MaxValue;

        Console.WriteLine("0:F2}",decimalMax);
        Console.WriteLine(longMax);

       //decimal bit = 5;
       //decimal secondBit = 5; //Bitwise operators are used ONLY on integer types

       // Console.WriteLine( bit | secondBit);
    }
}

