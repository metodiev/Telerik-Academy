using System;

//Write a program to convert hexadecimal numbers to their decimal representation.


class HexadecimalToDecimal
{
    static void HexaNumberToDecimal(string  hexNumbers)
    {
        int size = hexNumbers.Length;
        char[] hexNumber = new char[size];

        for (int i = 0; i < size; i++)
        {
            hexNumber[i] = hexNumbers[i];
        }

        Array.Reverse(hexNumber);
        int number = 0;
        for (int i = 0; i < size; i++)
        {
            int sum = HexTable(hexNumber, i);
            number += sum * Convert.ToInt32(Math.Pow(16,i));
        }

        Console.WriteLine(number);
    }

    static int HexTable(char [] hexnumber, int i)
    {
        int number = 0;
        if ((hexnumber[i] >= 48) && (hexnumber[i] <= 57))
	    {
		  for (int j = 48,p=0; j <= 58; j++, p++)
			{
			    if (hexnumber[i] == j)
	            {
		            number = p;
	            }
			}
	    }

        else if ((hexnumber[i] >= 65) && (hexnumber[i] <=90) )
	    {
		   number = HexSymbolsTable(hexnumber, i);
	    }

        return number;
    }

    static int HexSymbolsTable(char [] hex, int i)
    {
        int number = 0;
        switch (hex[i])
        {
            case 'A': number = 10;
                break;
            case 'B': number = 11;
                break;
            case 'C': number = 12;
                break;
            case 'D': number = 13;
                break;
            case 'E': number = 14;
                break;
            case 'F': number = 15;
                break;
            default:
                break;
        }
        return number;
    }

    static void Main()
    {
        Console.WriteLine("Enter hexadecimal number:");
        string hexNumber = Console.ReadLine().ToUpper();

        HexaNumberToDecimal(hexNumber);
    }
}

