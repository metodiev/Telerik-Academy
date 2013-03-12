using System;

class PrintFirst10MembersOfSequence
{
    static void Main()
    {
        int counter;
        for (counter = 2; counter < 12; counter++)
        {
            if ((counter % 2) == 0)
            {
                Console.WriteLine(counter);
            }
            else
            {
                Console.WriteLine("-" + counter);
            }
        }
    }
}

