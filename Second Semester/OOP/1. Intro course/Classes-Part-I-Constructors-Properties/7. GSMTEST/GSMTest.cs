using System;

//Write a class GSMTest to test the GSM class:
//Create an array of few instances of the GSM class.
//Display the information about the GSMs in the array.
//Display the information about the static property IPhone4S.

public class GSMTest
{
   public static void Main()
    {
        //Create an array of few instances of the GSM class.
        GSM [] phone = new GSM[100];

        for (int i = 0; i < phone.Length; i++)
        {
            phone[i] = new GSM();
            phone[i].Manufacturer = "Nokia";
            phone[i].Model = "Nokia 3310";
            phone[i].Owner = "Owner Name";
            phone[i].Price = 5555.55555M;
        }

        //Display the information about the GSMs in the array.
        for (int i = 0; i < phone.Length; i++)
        {
            Console.WriteLine("Phone Manufacturer {0}", phone[i].Manufacturer);
            Console.WriteLine("Phone model {0}", phone[i].Model);
            Console.WriteLine("Phone Owner {0}",phone[i].Owner );
            Console.WriteLine("Phone price {0}", phone[i].Price);
        }

       //display with Override Method ToString()
        for (int i = 0; i < phone.Length; i++)
        {
            phone[i].ToString();
        }

       //Information about Iphone4S
        GSM.Iphone4S = "White color 4 inch Lion Battery";
        //Display the information about the static property IPhone4S.
        Console.WriteLine("Iphone Infromation: {0}",GSM.Iphone4S);
    }
}

