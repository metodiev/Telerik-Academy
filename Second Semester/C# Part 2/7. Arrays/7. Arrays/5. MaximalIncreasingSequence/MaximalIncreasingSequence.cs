using System;

//Write a program that finds the maximal increasing sequence in an array.
//Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

class MaximalIncreasingSequence
{
    static void Main()
    {
        //enter lenght of array
        Console.WriteLine("Enter lenght of array");
        int lenght = int.Parse(Console.ReadLine());
        int[] arr = new int[lenght];

        //enter members of array
        for (int i = 0; i < lenght; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        
        int member = 0;
        int maxMemeber = 0;
        int[] sort = new int[arr.Length];
        int index = 0;

        //finds the maximal increasing sequence in an array
        for (int i = 0; i < arr.Length-1; i++)
        {
            if (arr[i+1] > arr[i])
            {
                member++;
                if (member > maxMemeber)
                {
                    maxMemeber = member;
                   
                }

                sort[i] = arr[i];
                sort[i + 1] = arr[i + 1];
            }

            else
            {
                index = i;
                member = 0;
                continue;
            }
        }

        Console.WriteLine("Index: {0}", index);
        Console.WriteLine("MaxMeber: {0}", maxMemeber);

        for (int i = index - maxMemeber-1; i < index; i++)
        {
            Console.WriteLine(sort[i]);
        }
    }
}

