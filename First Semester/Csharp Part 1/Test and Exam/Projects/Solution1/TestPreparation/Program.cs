using System;

class Program
{
    static void Main()
    {
        //int number = 5;
        //if (number++ == ++number)
        //{
        //    Console.WriteLine(number + 1);
        //}
        //else
        //{
        //    Console.WriteLine(number + 2);
        //}

        //
        //string[] elements = { "ab", "12" };
        //foreach (var e in elements)
        //{
        //    foreach (var ch in e)
        //    {
        //        Console.Write(ch);
        //    }
        //    Console.Write(e);
        //}

        //int n = 4, f = 0;
        //do
        //{
        //    f *= n;
        //    n--;
        //}
        //while (n > 0);
        //Console.WriteLine(f);


        //int sum = 0;
        //while (sum < 10)
        //    for (int i = 0; i <= 2; i++)
        //        sum += i;
        //Console.WriteLine(sum);

        double a = 1.0f;
        double b = 0.33f;
        double sum = 1.33f;
        bool equal = (a + b == sum); // False!!!
        Console.WriteLine("a+b={0}  sum={1}  equal={2}",
            a + b, sum, equal);


    }
}

