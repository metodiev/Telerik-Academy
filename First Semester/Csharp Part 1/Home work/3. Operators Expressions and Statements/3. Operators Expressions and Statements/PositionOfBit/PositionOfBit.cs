using System;

class PositionOfBit
{
    static void Main()
    {
        Console.WriteLine("Enter number v:");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position p you wanna check (counting form 0)");
        int p = int.Parse(Console.ReadLine());
        bool expresion = ((v & (1 << p)) == 0);
        //Console.WriteLine(Convert.ToString(v, 2));
        //Console.WriteLine(Convert.ToString((1 << p), 2));
        if (expresion)
        {
            Console.WriteLine("In the position {0} of number {1} the bit is 1: False", p, v);
        }
        else
        {
            Console.WriteLine("In the position {0} of number {1} the bit is 1: True", p, v);
        }
    }
}

