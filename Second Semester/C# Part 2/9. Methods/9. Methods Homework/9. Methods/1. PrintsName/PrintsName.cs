using System;

//Write a method that asks the user for his name and prints “Hello, <name>” 
//(for example, “Hello, Peter!”). Write a program to test this method.

class PrintsName
{
    static void PrintUsername()
    {
        string username = Console.ReadLine();
        Console.WriteLine("Hello {0}!", username);
    }

    static void Main()
    {
        Console.WriteLine("Enter your name:");
        PrintUsername();
    }
}

