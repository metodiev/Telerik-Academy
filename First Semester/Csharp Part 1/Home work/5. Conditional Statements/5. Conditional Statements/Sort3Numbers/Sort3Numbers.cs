using System;

//Sort 3 real values in descending
//order using nested if statements.

class Sort3Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers");
        int firstNumber;
        Console.WriteLine("First:");
        firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Second:");
        int secondNumber;
        secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Third:");
        int thirdNumber;
        thirdNumber = int.Parse(Console.ReadLine());
        int big = 0;
        int bigger = 0;
        int biggest = 0;

        big = Math.Min(firstNumber, Math.Min(secondNumber, thirdNumber));
        bigger = Math.Min(firstNumber, Math.Max(secondNumber, thirdNumber));
        biggest = Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber));
        bool expression = ((big < biggest) && (bigger < biggest));

        if (expression)
        {
            Console.WriteLine(
                "Big numer {0}, Bigger number {1}, Biggest number {2}", big, bigger, biggest
                             );
        }
        else
        {
            Console.WriteLine("Some numbers are equal");
            int[] numbers = new int[] { firstNumber, secondNumber, thirdNumber };
            Array.Sort(numbers);
            Console.WriteLine("numbers in descending order:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0}", numbers[i]);

            }
        }
     }   
}


