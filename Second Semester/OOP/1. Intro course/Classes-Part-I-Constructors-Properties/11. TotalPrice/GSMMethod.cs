using System;

//Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.

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

