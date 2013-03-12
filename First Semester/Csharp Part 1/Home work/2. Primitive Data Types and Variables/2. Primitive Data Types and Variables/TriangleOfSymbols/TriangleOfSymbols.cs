using System;

class TriangleOfSymbols
{
    static void Main()
    {
        string symbol = "©";
        string space = "  ";
        for (int i = 0; i < 3; ++i, symbol += "©©")
        {
            if (i == 1)
            {
                space = " ";
            }
            if (i == 2)
            {
                space = null;
            }

            Console.WriteLine((space + symbol).ToString()); 
        } 
    }
}

