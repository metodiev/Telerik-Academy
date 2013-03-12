using System;

class BankAccountData
{
    static void Main()
    {
        Console.WriteLine("Enter bank name");
        string bankName;
        bankName = Console.ReadLine();

        Console.WriteLine("Bank Account:");
        Console.WriteLine("Enter first name:");
        string firstName;
        firstName = Console.ReadLine();

        Console.WriteLine("Enter middle name:");
        string middleName;
        middleName = Console.ReadLine();

        Console.WriteLine("Enter last name:");
        string lastName;
        lastName = Console.ReadLine();

        Console.WriteLine("Enter balance:");
        decimal balance;
        balance = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter IBAN:");
        string IBAN;
        IBAN = Console.ReadLine();
        Console.WriteLine("Enter BIC code:");
        string bicCode;
        bicCode = Console.ReadLine();

        Console.WriteLine("Enter firtst credit card number:");
        ulong firstCreditCard;
        firstCreditCard = ulong.Parse(Console.ReadLine());
        Console.WriteLine("Enter second credit card number:");
        ulong secondCreditCard;
        secondCreditCard = ulong.Parse(Console.ReadLine());
        Console.WriteLine("Enter third credit card number:");
        ulong thirthCreditCard;
        thirthCreditCard = ulong.Parse(Console.ReadLine());

    }
}

