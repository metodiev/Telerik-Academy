using System;

//Write a program that finds the maximal sequence of equal elements in an array.
//  Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

class SequenceOfEqualElements
{
    static void Main()
    {
        //Enter lenght of array
        Console.WriteLine("Enter array lenght");
        int lenght = int.Parse(Console.ReadLine());
        int[] arr = new int[lenght];
        //Enter members of array
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int longSequence = 1;
        int next = 1;
        int longNumber = 0;
        int index = arr.Length-1;

        //check sequence for equal elements
        for (int i = 0; i < index; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                next += 1;
                if (next >= longSequence)
                {
                    longSequence = next;
                    longNumber = arr[i];
                }
            }
            else if (arr[i] != arr[i + 1])
            {
                next = 1;
            }

        }

        //print equal elements
        Console.WriteLine("Maximal sequence of equal elements {0}:",longSequence);
        for (int i = 0; i < longSequence; i++)
        {
            Console.Write("{0},", longNumber);
        }
    }
}

