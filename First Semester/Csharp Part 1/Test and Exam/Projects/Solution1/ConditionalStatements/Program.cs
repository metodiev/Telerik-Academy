using System;

class Program
{
    static void Main()
    {
        decimal x = decimal.Parse(Console.ReadLine());
        decimal y = decimal.Parse(Console.ReadLine());
        
        if (x !=0 && y != 0)
        {
            bool first= (x > 0 && y > 0); 
            uint choice = 0;
            if (x > 0 && y > 0)
            {
             choice = 1;
            }
            if (x < 0 && y >0 )
            {
                choice = 2;
            }
            if (x < 0 && y <0)
            {
               choice = 3;
            }
            if (x > 0 && y < 0)
            {
                choice = 4;
            }
            switch (choice)
            {
                case 1: Console.WriteLine(1);
                    break;
                case 2: Console.WriteLine(2);
                    break;
                case 3: Console.WriteLine(3);
                    break;
                case 4: Console.WriteLine(4);
                    break;
                default: Console.WriteLine("");
                    break;
            }
        }
        else if (x == 0 && y != 0)
        {
            Console.WriteLine(5);
        }
        else if (x != 0 && y == 0)
        {
            Console.WriteLine(6);
        }
        else { Console.WriteLine(0); }
   
    }
}

