using System;

//Write a program to convert from any numeral system of given base s 
//to any other numeral system of base d (2 ≤ s, d ≤  16).

class ConvertToAnyNumSystem
{
    static int ConvertToDecimal(string n , int s)
    {
        int result = 0;

        for (int i = 0; i < n.Length; i++)
        {
            result += Convert.ToInt32(n.Substring(i, 1)) * (int)Math.Pow(s, n.Length - 1 - i);
        }
        return result;
    }

    static string ConvertToDSystem(int number, int d)
    {
        string converted = null;
        while (number > 0)
        {
            switch (number % d)
            {
                case 0: converted+= "0"; break;
                case 1: converted+= "1"; break;
                case 2: converted+= "2"; break;
                case 3: converted+= "3"; break;
                case 4: converted+= "4"; break;
                case 5: converted+= "5"; break;
                case 6: converted+= "6"; break;
                case 7: converted+= "7"; break;
                case 8: converted+= "8"; break;
                case 9: converted+= "9"; break;
                case 10:converted+= "A"; break;
                case 11:converted+= "B"; break;
                case 12:converted+= "C"; break;
                case 13:converted+= "D"; break;
                case 14:converted+= "E"; break;
                case 15:converted+= "F"; break;
                default:converted+= ""; break;
            }
            number = number / d;
        }

        return converted;
    }

    static void PrintSystem(string endNumber)
    {
        int size = endNumber.Length;
        char[] charArray = new char[size];
        for (int i = 0; i < size; i++)
        {
            charArray[i] = endNumber[i];
        }
    
        Array.Reverse(charArray);
        for (int i = 0; i < charArray.Length; i++)
        {
            Console.Write(charArray[i]);
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter symbols/numbers");
        string n = Console.ReadLine().ToUpper();
        int s = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int endNumber = ConvertToDecimal(n, s);

        string converted = ConvertToDSystem(endNumber, d);
        PrintSystem(converted);
    }
}
