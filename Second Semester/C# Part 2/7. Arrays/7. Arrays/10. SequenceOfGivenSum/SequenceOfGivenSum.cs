using System;

//10.Write a program that finds in given array of integers a 
//sequence of given sum S (if present).
//Example:  {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5} 

class SequenceOfGivenSum
{
    static void Main()
    {
        Console.WriteLine("Enter array length");
        int arrayLength = int.Parse(Console.ReadLine());

        int[] arr = new int[arrayLength];
        Console.WriteLine("Enter array element");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Enter member:{0}", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter S:");
        int s = int.Parse(Console.ReadLine());
        
        int sum = 0;
        int index = 0;
        int[] arrIndex = new int[arr.Length];
        bool Istrue = false;

        for (int i = 0; i < arr.Length-1; i++)
        {
            sum += arr[i];
            index = i;
            for (int j = i+1; j < arr.Length; j++)
            {
                sum += arr[j];
                if (sum == s)
                {
                    Istrue = true;
                    
                    for (int p = index, ind=0; p <=j ; p++, ind++)
                    {
                        arrIndex[ind] = arr[p];
                    }
                }
            }
            sum = 0;
        }
       
        if (Istrue)
        {
            for (int i = 0; i < arrIndex.Length; i++)
            {
                if (arrIndex[i]!=0)
                {
                    Console.WriteLine(arrIndex[i]);
                }
               
            }
        }
        
    }
}

