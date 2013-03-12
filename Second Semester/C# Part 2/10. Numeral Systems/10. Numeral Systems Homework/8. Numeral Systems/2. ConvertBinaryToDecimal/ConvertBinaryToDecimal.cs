using System;

//Write a program to convert binary numbers to their decimal representation.

class ConvertBinaryToDecimal
{
    static void BinaryToDecimal(string binary)
    {
        int number = 0;
        int[] arr = new int[binary.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            if (binary[i] == 48)
            {
                 arr[i] = 0;
            }
            else if (binary[i] == 49)
            {
                arr[i] = 1;
            }
           // Console.WriteLine(arr[i]);
        }

        for (int i = 0, j = arr.Length-1; i < arr.Length; i++, j-- )
        {
            number += arr[j] * Convert.ToInt32(Math.Pow(2, i));
        }
        Console.WriteLine(number);
    }

    static void Main()
    {
        Console.WriteLine("Enter binary number");
        string binary = Console.ReadLine();
        BinaryToDecimal(binary);
    }
}

