using System;

//11.Write a program that finds the index of given element in a sorted array of 
//integers by using the binary search algorithm (find it in Wikipedia).

class BinarySearchAlgorithm
{
    static void Main()
    {
        Console.WriteLine("Enter array length:");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] arr = new int[arrayLength];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Enter {0} member:", i+1);
            arr[i] = int.Parse(Console.ReadLine());
        }
        int number = arrayLength;
        int startNumber = 0;
        int middleNumber = 0;
        int endNumber = arr.Length - 1;
        //Array.Sort(arr);
        while (startNumber <= endNumber)
        {
            middleNumber = (startNumber + endNumber) / 2;

            if (arr[middleNumber] ==  number)
            {
                Console.WriteLine(middleNumber);
                break;
            }

            if (arr[middleNumber] < number)
            {
                startNumber = middleNumber + 1;
            }

            if (arr[middleNumber] > number)
            {
                startNumber = middleNumber - 1;
            }
        }

        Console.WriteLine(startNumber);
        Console.WriteLine(middleNumber);
    }
}

