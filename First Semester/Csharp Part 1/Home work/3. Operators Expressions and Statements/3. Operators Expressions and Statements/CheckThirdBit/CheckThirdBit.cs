using System;

class CheckThirdBit
{
    static void Main()
    {
        Console.WriteLine("Enter integer number");
        int number;
        number = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2));

        bool temp = ((number & (1 << 3)) == 0);
        if (temp)
        {
            Console.WriteLine("Third bit is  0 (counting from 0)");
        }
        else
        {
            Console.WriteLine("Third bit is 1 (counting from 0)");
        }

    }
}

