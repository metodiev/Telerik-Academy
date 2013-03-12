using System;

class Program
{
    static void Main()
    {
        int pX1 = int.Parse(Console.ReadLine());
        int pY1 = int.Parse(Console.ReadLine());
        int pX2 = int.Parse(Console.ReadLine());
        int pY2 = int.Parse(Console.ReadLine());

        int fX = int.Parse(Console.ReadLine());
        int fY = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        int hitX = fX + d;
        int hitY = fY;
        int hit75X;
        int hit75Y = fY;
        if (d >= 0)
        {
            hit75X = hitX + 1;
        }
        else 
        {
            hit75X = hitX - 1;
        }
        int hitUpper = hitX;
        int hitUpperY = hitY + 1;
        int hitLowerX = hitX;
        int hitLowerY = hitY - 1;

        int pUpper = Math.Max(pY1, pY2);
        int pLower = Math.Min(pY1, pY2);
        int pLeft = Math.Min(pX1, pX2);
        int pRight = Math.Max(pX1, pX2); 
        int sum = 0;
        int currentDamage = 100;

        int currentCheckX = hitX;
        int currentCheckY = hitY;
        if (currentCheckY >= pLower && currentCheckY <= pUpper )
        {
            if (currentCheckX >= pLeft && currentCheckX <= pRight)
            {
                sum += currentDamage;
            }
        }

        currentCheckX = hit75X;
        currentCheckY = hit75Y;
        currentDamage = 75;

        if (currentCheckY >= pLower && currentCheckY <= pUpper)
        {
            if (currentCheckX >= pLeft && currentCheckX <= pRight)
            {
                sum += currentDamage;
            }
        }


        currentCheckX = hitUpper ;
        currentCheckY = hitUpperY;
        currentDamage = 50;

        if (currentCheckY >= pLower && currentCheckY <= pUpper)
        {
            if (currentCheckX >= pLeft && currentCheckX <= pRight)
            {
                sum += currentDamage;
            }
        }


        currentCheckX = hitLowerX;
        currentCheckY = hitLowerY;
        currentDamage = 50;

        if (currentCheckY >= pLower && currentCheckY <= pUpper)
        {
            if (currentCheckX >= pLeft && currentCheckX <= pRight)
            {
                sum += currentDamage;
            }
        }
        Console.WriteLine(sum+"%");
    }
}
