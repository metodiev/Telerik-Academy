using System;
using System.Collections.Generic;
//Write a program that finds the most frequent number in an array. Example:
// {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

class MostFrequentNumber
{
    static void Main()
    {

        Console.WriteLine("Enter array Length");
        int arrayLength = int.Parse(Console.ReadLine());

        int[] arr = new int[arrayLength];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

            int element = 0;
            int equal = 0;
            int maxEqual = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                equal = 0;
                for (int j= 0; j < arr.Length; j++)
                {
                    if (arr[i]==arr[j])  
                    {
                        ++equal;
                        if (equal > maxEqual)
                        {
                            element = arr[i];
                            maxEqual = equal;
                        }
                    }
                }
            }

            Console.WriteLine("Element:{0}, Equal times:{1}", element, maxEqual);
        }
 }


