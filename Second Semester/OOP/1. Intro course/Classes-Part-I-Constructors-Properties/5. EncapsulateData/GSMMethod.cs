using System;

//Add a method in the GSM class for displaying all information about it. Try to override ToString().

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

