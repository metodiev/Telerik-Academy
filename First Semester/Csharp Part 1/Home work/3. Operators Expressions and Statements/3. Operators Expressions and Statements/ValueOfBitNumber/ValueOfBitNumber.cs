using System;

class ValueOfBitNumber
{
    static void Main()
    {
        Console.WriteLine("Enter number i:");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position b you wanna check (counting form 0)");
        int b = int.Parse(Console.ReadLine());
        bool expresion = ((i & (1 << b)) == 0);
        /*Console.WriteLine(Convert.ToString(i, 2));
        Console.WriteLine(Convert.ToString((1 << b), 2));*/

        if (expresion)
        {
            Console.WriteLine("In the position {0} of number {1}the bit is: 0", b, i);
        }
        else
        {
            Console.WriteLine("In the position {0} of number {1} the bit is: 1", b, i);
        }
    }
}

