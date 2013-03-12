using System;

class ChangeBitValue
{
    static void Main()
    {
        Console.WriteLine("Enter integer number n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position p you wanna change (counting form 0)");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of bit: v (1 or 0)");
        int v;
        v = int.Parse(Console.ReadLine());
        int bit;
        if (v == 1)
        {
            bit = ((v << p) | n);
            Console.WriteLine(Convert.ToString((bit), 2));  
        }
        else
        {
            int mask = ~(1 << p);       
            int result = n & mask;      
            Console.WriteLine(result);
            Console.WriteLine(Convert.ToString((result), 2));   
        }
    }
}

