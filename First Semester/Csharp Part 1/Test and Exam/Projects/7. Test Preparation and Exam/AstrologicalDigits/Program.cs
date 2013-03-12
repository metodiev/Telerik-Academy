using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
       
            for (int j = 0; j < N; j++)
            {
                Console.Write(".");
            }
            for (int q = 0; q < N; q++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            for (int i = 0; i < N - 1; i++)
            {
                for (int j = 0; j < N-(1+i); j++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int q = 0; q < N +(i-1); q++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                Console.WriteLine();
            }
            
            for (int i = 0; i < 2*N; i++)
            {
                Console.Write("*");
            }


        //string input = Console.ReadLine();
        //int calculated = 0;
        //do
        //{
        //    calculated = 0;
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        if (input[i] != '.' && input[i] != '-')
        //        {
        //            calculated += (input[i] - '0');
        //        }
        //    }
        //    input = calculated.ToString();
        //} while (calculated > 9);

        //Console.WriteLine(input[1]);
        //Console.WriteLine(calculated);
    }
}

