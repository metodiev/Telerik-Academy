using System;

class MarketingFirmRecords
{
    static void Main()
    {
        Console.WriteLine("Employee data:");

        Console.WriteLine("1. Enter emloyee first name:");
        string firstName;
        firstName = Console.ReadLine();

        Console.WriteLine("2. Enter employee family name:");
        string familyName;
        familyName = Console.ReadLine();

        Console.WriteLine("3. Enter employee age:");
        byte employeeAge;
        employeeAge = byte.Parse(Console.ReadLine());

        Console.WriteLine("4. Enter gender of employee (m/f):");
        char gender;
        gender = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("5. Enter id of employee (max value 65535):");
        ushort idNumber;
        idNumber =  ushort.Parse(Console.ReadLine());

        Console.WriteLine("6. Enter unique employee number between (27560000 and 27569999):");
        uint uniqueEmployeeNumber;
        uniqueEmployeeNumber = uint.Parse(Console.ReadLine());

        Console.WriteLine("Employee data:");
        Console.WriteLine("Name: {0}\nFamily name:{1}\nAge: {2}\nID: {3}\nUnique employee number: {4}", firstName, familyName, employeeAge, idNumber, uniqueEmployeeNumber);
    }
}

