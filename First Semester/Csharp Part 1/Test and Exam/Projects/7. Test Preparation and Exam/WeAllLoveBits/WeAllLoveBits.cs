using System;
using System.Numerics;

class WeAllLoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string number = null;
        string bitsString = null;
        //string other = null;

        for (int i = 0; i < n; i++)
        {
            bitsString = String.Empty; 
            int num = int.Parse(Console.ReadLine());
            number = Convert.ToString(num , 2);
          // Console.WriteLine(number);
            int temp = number.Length;
            // Console.WriteLine(temp);
            for (int j = 1; j <= temp; j++)
            {
                
                bitsString += number.Substring(number.Length - j, 1);

            }
           // Console.WriteLine(bitsString);
            BigInteger a = Convert.ToUInt64(bitsString, 2);
            Console.WriteLine(a);

        }
        
        

        //    int bits = int.Parse(Console.ReadLine());
        //    int result = 0;
        //    while (bits > 0)
        //    {
        //        int lastBit = bits & 1;
        //        result = result << 1;
        //        result = result | lastBit;
        //        bits = bits >> 1;

        //    }
        //    Console.WriteLine(result);
        //}

    }
}

