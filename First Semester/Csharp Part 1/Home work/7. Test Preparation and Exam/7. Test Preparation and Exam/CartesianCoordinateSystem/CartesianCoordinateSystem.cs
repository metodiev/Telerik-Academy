using System;

//Input:
//Input data is being read from the console. 
//The number X is on the first input line.
//The number Y is on the second input line.
//The input data will always be valid and in the 
//format described. There is no need to check it explicitly.

//Output:
//The output data must be printed on the console.
//On the only output line you must print an integer number between 0 and 6, depending on the location of the given point in the coordinate system.
//Constraints
//The numbers X and Y are numbers between -2 000 000 000 001 337 and 2 000 000 000 001 337, inclusive.

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        
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