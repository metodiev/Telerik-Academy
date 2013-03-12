using System;

//14.Write a program that sorts an array of 
//strings using the quick sort algorithm (find it in Wikipedia).

class QuickSortAlgorithm
{
    static void Main()
    {
        //Unsorted array of string elements
        Console.WriteLine("Enter array length:");
        int length = int.Parse(Console.ReadLine());
        string[] unsorted = new string[length];
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("Enter {0} letter of string", i);
            unsorted[i] = Console.ReadLine();
        }
     
        //Sort the array
        QuickSort(unsorted, 0, unsorted.Length - 1);

        //Sorted array

        for (int i = 0; i < unsorted.Length; i++)
        {
            Console.WriteLine(unsorted[i] + " ");
        }
    }

    public static void QuickSort(IComparable[] elements, int left, int right)
    {   //IComparable provide a method of comparing two objects 
        int i = left;
        int j = right;
        IComparable pivot = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                IComparable temp = elements[i];
                elements[i] = elements[j];
                elements[j] = temp;

                i++;
                j--;
            }

            if (left < j)
            {   //recursive call
                QuickSort(elements, left, j);
            }

            if (i < right)
            {   //recursive call
                QuickSort(elements, i, right);
            }
        }
    }
}

