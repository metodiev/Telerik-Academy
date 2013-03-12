using System;

//3. A company has name, address, phone number, fax number,
//web site and manager. The manager has first name, last name, 
//age and a phone number. Write a program that reads the 
//information about a company and its manager and prints them on the console.


class CompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Enter company name:");
        string companyName;
        companyName = Console.ReadLine();

        Console.WriteLine("Enter company address:");
        string companyAddress;
        companyAddress = Console.ReadLine();

        Console.WriteLine("Enter company phone number:");
        long companyPhone;
        companyPhone = long.Parse(Console.ReadLine());

        Console.WriteLine("Enter company fax number:");
        long companyFax;
        companyFax = long.Parse(Console.ReadLine());

        Console.WriteLine("Enter company web site:");
        string companyWebSite;
        companyWebSite = Console.ReadLine();

        Console.WriteLine("Enter company manager:");
        string companyManager;
        companyManager = Console.ReadLine();

        Console.WriteLine("Enter manager first name:");
        string managerFirstName;
        managerFirstName = Console.ReadLine();

        Console.WriteLine("Enter manager last name:");
        string managerLastName;
        managerLastName = Console.ReadLine();

        Console.WriteLine("Enter how old is manager:");
        byte managerAge;
        managerAge = byte.Parse(Console.ReadLine());

        Console.WriteLine("Enter manager phone number:");
        ulong managerPhoneNumber;
        managerPhoneNumber = ulong.Parse(Console.ReadLine());

        Console.WriteLine("Data for Company and Manager:");
        Console.WriteLine(
            "Company data: {0}, {1}, {2}, {3}, {4}, {5}",companyName,
            companyAddress, companyPhone, companyFax, companyWebSite,
            companyManager);
        Console.WriteLine(
            "Manager data: {0}, {1}, {2}, {3}, {4}", managerFirstName,
            managerLastName, managerAge, managerPhoneNumber);
    }
}

