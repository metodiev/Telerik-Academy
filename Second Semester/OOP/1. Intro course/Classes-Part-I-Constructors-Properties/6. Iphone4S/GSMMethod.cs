using System;

//Write a class GSMTest to test the GSM class:
//Create an array of few instances of the GSM class.
//Display the information about the GSMs in the array.
//Display the information about the static property IPhone4S.


class Mobileinformation
{
    static void Main()
    {
        GSM phone = new GSM();
        phone.Manufacturer = "Nokia";
        phone.Model = "Nokia";
        phone.Price = 55.4565M;
        phone.Owner = "Shmatkata";
        Console.WriteLine(phone);
    }
}

