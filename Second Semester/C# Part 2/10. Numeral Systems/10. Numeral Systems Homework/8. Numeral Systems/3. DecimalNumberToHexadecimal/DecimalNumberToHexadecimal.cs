using System;

//Write a program to convert decimal numbers to their hexadecimal representation.

class DecimalNumberToHexadecimal
{
    static void DecimalToHexadecimal(int num)
    {
        int temp = 0;
        int count = 0;
        int tempCount = 0;
        int tempNumber = num;

        while (tempNumber > 0)
        {
            tempCount = num % 16;
            tempNumber /= 16;
            count++;
        }

        string [] hexadecimal = new string[count];
        for (int i = 0; i < count; i++)
		{
			temp = num % 16;
            num /= 16;
            if (temp > 9)
            {
                hexadecimal[i] =  HexSymbol(temp, i, hexadecimal);
            }

            if (temp < 10 )
            {
                hexadecimal[i] = temp.ToString();
            }
		}

        Array.Reverse(hexadecimal);
        PrintHexNumber(hexadecimal, count);
       
    }

    static string HexSymbol(int temp, int i, string [] hexadecimal)
    {
        switch (temp)
        {
            case 10: hexadecimal[i] = "A";
                break;
            case 11: hexadecimal[i] = "B";
                break;
            case 12: hexadecimal[i] = "C";
                break;
            case 13: hexadecimal[i] = "D";
                break;
            case 14: hexadecimal[i] = "E";
                break;
            case 15: hexadecimal[i] = "E";
                break;
            case 16: hexadecimal[i] = "F";
                break;
            default:
                break;
        }
        return hexadecimal[i];
    }

    static void PrintHexNumber(string[] hexadecimal, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write(hexadecimal[i]);
        }

        Console.WriteLine();
    }

    static void Main()
    {
        Console.WriteLine("Enter decimal number:");
        int number = int.Parse(Console.ReadLine());
        DecimalToHexadecimal(number);
    }
}

