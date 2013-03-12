using System;

//Input:
//The input data should be read from the console.
//There will be exactly 11 lines holding the integer numbers SX1, SY1, SX2, SY2, H, CX1, CY1,
//CX2, CY2, CX3, and CY3. The ship S is given by any two of its opposite corners and is
//non-empty (has positive width and height). The line H is given by its vertical offset. 
//The points C1, C2 and C3 are given as couples of coordinates and cannot overap each other.
//The input data will always be valid and in the format described. There is no need to check it explicitly.

//Output:
//The output data should be printed on the console.
//The output should consist of a single line holding the total damage given as percentage.

//Constraints:
//The numbers SX1, SY1, SX2, SY2, H, CX1, CY1, CX2, CY2, CX3, and CY3 are all integers between -100 000 and 100 000, inclusive.


class Program
{
    static void Main()
    {
        int ship1X = int.Parse(Console.ReadLine());
        int ship1Y = int.Parse(Console.ReadLine());
        int ship2X = int.Parse(Console.ReadLine());
        int ship2Y = int.Parse(Console.ReadLine());
        int hor = int.Parse(Console.ReadLine());
        int c1x = int.Parse(Console.ReadLine());
        int c1y = int.Parse(Console.ReadLine());
        int c2x = int.Parse(Console.ReadLine());
        int c2y = int.Parse(Console.ReadLine());
        int c3x = int.Parse(Console.ReadLine());
        int c3y = int.Parse(Console.ReadLine());

        ship1Y -= hor;
        ship2Y -= hor;
        c1y -= hor;
        c2y -= hor;
        c3y -= hor;
        int reflectedC1Y = -c1y;
        int reflectedC2Y = -c2y;
        int reflectedC3Y = -c3y;

        int top = Math.Max(ship1Y, ship2Y);
        int left = Math.Min(ship1Y, ship2X);
        int right = Math.Max(ship1X, ship2X);
        int bottom = Math.Min(ship1Y, ship2Y);

        int sum = 0;

        if (reflectedC1Y < top && reflectedC1Y > bottom)
        {
            if (c1x < right && c1x > left)
            {
                sum += 100;
            }
            else if (c1x == left || c1x == right)
            {
                sum += 50;
            }
        }
        if (reflectedC1Y == top  || reflectedC1Y == bottom)
        {
            if (c1x < right && c1x > left)
            {
                sum += 50;
            }
            else if (c1x == left || c1x == right)
            {
                sum += 25;
            }
        }

        if (reflectedC2Y < top && reflectedC2Y > bottom)
        {
            if (c2x < right && c2x > left)
            {
                sum += 100;
            }
            else if (c2x == left || c2x == right)
            {
                sum += 50;
            }
        }
        if (reflectedC2Y == top || reflectedC2Y == bottom)
        {
            if (c2x < right && c2x > left)
            {
                sum += 50;
            }
            else if (c2x == left || c2x == right)
            {
                sum += 25;
            }
        }

        if (reflectedC3Y < top && reflectedC3Y > bottom)
        {
            if (c3x < right && c3x > left)
            {
                sum += 100;
            }
            else if (c3x == left || c3x == right)
            {
                sum += 50;
            }
        }
        if (reflectedC3Y == top || reflectedC3Y == bottom)
        {
            if (c3x < right && c3x > left)
            {
                sum += 50;
            }
            else if (c3x == left || c3x == right)
            {
                sum += 25;
            }
        }
        Console.WriteLine(sum +"%");
    }             

}                 
