using System;

//Write a program that reads two arrays from the console
//and compares them element by element.

class CompareArrays
{
    static void Main(string[] args)
    {
        Console.WriteLine("To compare arrays the lenght of them must be equal");
        Console.WriteLine("Ener lenght of two arrays:");
        int member = int.Parse(Console.ReadLine());
        int [] firstArr = new int[member];

        int [] secondArr = new int[member];
        Console.WriteLine("Enter first array");
        for (int i = 0; i < firstArr.Length; i++)
        {
            Console.WriteLine("Ener {0} element", i);
            firstArr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter second array");

        for (int i = 0; i < secondArr.Length; i++)
        {
            Console.WriteLine("Enter {0} element of array", i);
            secondArr[i] = int.Parse(Console.ReadLine());
        }

        bool compareArr = true;

        for (int i = 0; i < secondArr.Length; i++)
        {
            if (firstArr[i] != secondArr[i])
            {
                compareArr = false;
                break;
            }
        }
        Console.WriteLine("Two array are equal {0}", compareArr);
    }
}

