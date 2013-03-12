using System;

class Program
{
    static void Main()
    {
        int K = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        string readBits = null;

        for (int i = 0; i < N; i++)
        {
            int readNumbers = int.Parse(Console.ReadLine());
            readBits = readBits + Convert.ToString(readNumbers, 2);
        }
        int numberOfBits = readBits.Length;
        Console.WriteLine(readBits);
       // Console.WriteLine(numberOfBits);
        string one = "1";
        string zero = "0";
        string ones = one.PadLeft(K,'1');
     //   Console.WriteLine(ones);
        string zeros = zero.PadLeft(K,'0');
        Console.WriteLine(zeros);
        int temp = ones.Length;
       // Console.WriteLine(temp);
        string other = null;
        string mystring = readBits;
        int count = 0;
        for (int i = temp; i <= numberOfBits; i++)
        {
            other = mystring.Substring(mystring.Length - i, temp);
            Console.WriteLine(other);
             if (ones == other)
             {
                 count++;
                // i = i + temp;
             }
             if (zeros == other)
             {
                 count++;
                 //i = i + temp;
             }
             
        }
        Console.WriteLine(count);
    }
}

