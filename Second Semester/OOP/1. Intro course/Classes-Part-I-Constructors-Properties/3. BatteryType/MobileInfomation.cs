using System;

//Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.

class Mobileinformation
{
    static void Main()
    {
        GSM phone = new GSM();
        Console.WriteLine("Enter GSM model:");
        phone.Model = Console.ReadLine();
        Console.WriteLine("Enter GSM owner:");
        phone.Owner = Console.ReadLine();
        Console.WriteLine("Enter phone price");
        phone.Price = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter phone Manufacturer:");
        phone.Manufacturer = Console.ReadLine();

        Display disp = new Display();
        Console.WriteLine("Enter display number of colors");
        disp.NumberOfColors = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter display size:");
        disp.Size = int.Parse(Console.ReadLine());

        Battery battery = new Battery();
        Console.WriteLine("Enter battery model:");
        Console.WriteLine("Lion\nNiMH\nLiPoly\nNiCd\nNiC");
        Battery.BatteryType value = Battery.BatteryType.NiC;
        switch (value)
        {
            case Battery.BatteryType.Lion:
                break;
            case Battery.BatteryType.NiMH:
                break;
            case Battery.BatteryType.LiPoly:
                break;
            case Battery.BatteryType.NiCd:
                break;
            case Battery.BatteryType.NiC:
                break;
            default:
                break;
        }
        
        
    
        battery.Model = Console.ReadLine();
        Console.WriteLine("Enter battery hours idle");
        battery.HoursIdle = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter battery hours talk");
        battery.HoursTalk = int.Parse(Console.ReadLine());

       
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("Phone model: {0}\nPhone owner: {1}\nPhone Manufacturer: {2}\nPhone Price: {3}", phone.Model, phone.Owner, phone.Manufacturer, phone.Price);
        Console.WriteLine();
        Console.WriteLine("Phone characteristics\nDisplay size:{0}\nDisplay number of colors: {1} ", disp.Size, disp.NumberOfColors);
        Console.WriteLine();
        Console.WriteLine("Phone Battery characteristics\nBattery Model:{0}\nBattery hours Idle:{1}\nBattery hours talk:{2}", battery.Model, battery.HoursIdle, battery.HoursTalk);

    }
}

