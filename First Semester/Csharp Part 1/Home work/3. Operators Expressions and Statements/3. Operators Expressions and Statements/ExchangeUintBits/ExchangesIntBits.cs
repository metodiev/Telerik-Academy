using System;

class ExchangesIntBits
{
    static void Main()
    {
        Console.WriteLine("Enter uint number:");
        uint number;
        number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Entered number:");
        Console.WriteLine(Convert.ToString((number), 2));

        uint getBits;
        getBits = ((7 << 3) & number);
        uint getOtherBits;
        getOtherBits = ((7 << 24) & number);

        getOtherBits = (getOtherBits >> 21);
        //Console.WriteLine(Convert.ToString((getOtherBits), 2));
        getBits = (getBits << 21);
        //Console.WriteLine(Convert.ToString((getBits), 2));
       
        number = Convert.ToUInt32(number & (~( 7 << 3)));
        //Console.WriteLine(Convert.ToString(number, 2));
        number = Convert.ToUInt32(number & (~(7 << 21)));
        //Console.WriteLine(Convert.ToString(number, 2));
        number = number | getOtherBits;
        number = number | getBits;
      
        Console.WriteLine(Convert.ToString(number, 2));
    }
}

