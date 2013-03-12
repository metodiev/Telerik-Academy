using System;

//Write a program that compares two char arrays lexicographically (letter by letter).

class ComparesTwoCharArrays
{
    static void Main()
    {
        char [] compareArr = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',	'm', 
                                 'n', 'o', 'p',	'q', 'r', 's', 't',	'u', 'v', 'w', 'x',	'y', 'z'};

       
        Console.WriteLine("How many characterrs you wanna" + " "+
                          "be your fist and second array");
        int character = int.Parse(Console.ReadLine());
        char[] firstArr = new char[character];
        char[] secondArr = new char[character];
        Console.WriteLine("Enter first array letters (small letters)");

        //Enter first Array
        for (int i = 0; i < firstArr.Length; i++)
        {
            firstArr[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter second array letters (small letters)");

        //Enter second Array
        for (int i = 0; i < secondArr.Length; i++)
        {
            secondArr[i] = char.Parse(Console.ReadLine());
        }
       
        int firstCount = 0;//Count if letters are sorted
        int secondCount = 0;
       
        //Comparing the order of two arrays
        for (int i = 0; i < firstArr.Length; i++)
        {
            if (compareArr[i] == firstArr[i])
            {
                firstCount++;
            }
        }

        for (int i = 0; i < secondArr.Length;i++)
        {
           
            if (secondArr[i] == compareArr[i])
            {
                secondCount++;
            }
        }

        if (firstCount > secondCount)
        {
            Console.WriteLine("First array is more lexicographically ordered than second");
        }

        else if (secondCount > firstCount)
        {
            Console.WriteLine("Second array is more lexicographically ordered than first");
        }

        else
        {
            Console.WriteLine("Two arrays are equal");
        }
    }
}

