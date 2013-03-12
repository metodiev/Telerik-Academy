using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {

        string[] bigAlpha = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        string[] smallAlpha = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" }; ;

        ulong n = ulong.Parse(Console.ReadLine());
        string[] str = new string[256 * 256];

        ulong p = (n % 26);
        // Console.WriteLine(p);

        int sum = 0;
        int pesho = 0;

        for (uint i = 0; i < 256 * 256; i++)
        {

            if (n <= 25)
            {
                for (uint j = i; j < bigAlpha.Length; j++)
                {
                    str[j] = bigAlpha[j];
                }
            }

            if (n >= 26)
            {

                if (i % 26 == 0 || pesho == 0)
                {
                    sum = 0;
                    pesho++;


                }
                if (i % 25 == 0 && pesho > 0)
                {

                    sum++;
                }



                str[i] = smallAlpha[sum];

                string last = null;
                for (uint j = 0; j < p; j++)
                {
                    str[j] = bigAlpha[p];
                    last = str[j];

                }

                str[i] += last;
            }

            if (n > 77)
            {
                str[i] = smallAlpha[2];

                string last = null;
                for (uint j = 0; j < p; j++)
                {
                    str[j] = bigAlpha[p];
                    last = str[j];

                }

                str[i] += last;
            }

            if (n > 102)
            {
                str[i] = smallAlpha[3];

                string last = null;
                for (uint j = 0; j < p; j++)
                {
                    str[j] = bigAlpha[p];
                    last = str[j];

                }

                str[i] += last;
            }

            if (n > 127)
            {
                str[i] = smallAlpha[4];

                string last = null;
                for (uint j = 0; j < p; j++)
                {
                    str[j] = bigAlpha[p];
                    last = str[j];

                }

                str[i] += last;
            }


            if (n > 152)
            {
                str[i] = smallAlpha[5];

                string last = null;
                for (uint j = 0; j < p; j++)
                {
                    str[j] = bigAlpha[p];
                    last = str[j];

                }

                str[i] += last;
            }

            if (n > 177)
            {
                str[i] = smallAlpha[6];

                string last = null;
                for (uint j = 0; j < p; j++)
                {
                    str[j] = bigAlpha[p];
                    last = str[j];

                }

                str[i] += last;
            }


             if (n > 207)
            {
                str[i] = smallAlpha[7];

                string last = null;
                for (uint j = 0; j < p; j++)
                {
                    str[j] = bigAlpha[p];
                    last = str[j];

                }

                str[i] += last;
            }

             if (n > 227)
             {
                 str[i] = smallAlpha[8];

                 string last = null;
                 for (uint j = 0; j < p; j++)
                 {
                     str[j] = bigAlpha[p];
                     last = str[j];

                 }

                 str[i] += last;
             }

             if (n > 252)
             {
                 str[i] = smallAlpha[9];

                 string last = null;
                 for (uint j = 0; j < p; j++)
                 {
                     str[j] = bigAlpha[p];
                     last = str[j];

                 }

                 str[i] += last;
             }

        }


        Console.WriteLine(str[n]);

    }
}