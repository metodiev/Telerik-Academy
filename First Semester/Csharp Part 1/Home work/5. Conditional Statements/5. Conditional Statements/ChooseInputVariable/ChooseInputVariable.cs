using System;

//Write a program that, depending on the
//user's choice inputs int, double or string variable. 
//If the variable is integer or double, increases it with 1. 
//If the variable is string, appends "*" at its end. 
//The program must show the value of that variable as a console output.
//Use switch statement.

class ChooseInputVariable
{
    static void Main()
    {
        Console.WriteLine("Enter input variable (int, double or string)");
        Console.WriteLine("To enter int type 1:");
        Console.WriteLine("To enter double type 2:");
        Console.WriteLine("To enter string type 3:");
        int intVariable;
        double doubleVariable;
        string stringVariable;
        int choice;
        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: Console.WriteLine("Enter integer variable:");
                    intVariable = int.Parse(Console.ReadLine()); 
                    intVariable = intVariable + 1; 
                    Console.WriteLine("Integer variable {0}", intVariable);
                    break;
            case 2: Console.WriteLine("Enter double variable :");
                    doubleVariable = double.Parse(Console.ReadLine()); 
                    doubleVariable = doubleVariable + 1;
                    Console.WriteLine("Double variable {0}", doubleVariable);
                    break;
            case 3: Console.WriteLine("Enter string variable:");
                    stringVariable = Console.ReadLine();
                    stringVariable = stringVariable + "*";
                    Console.WriteLine("String variable: {0}", stringVariable);
                    break;

            default: Console.WriteLine("Incorrect choice please try again");
                break;
        }
    }
}

