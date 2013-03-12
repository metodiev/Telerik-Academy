using System;

//Write a program to convert hexadecimal numbers to binary numbers (directly).

class HexadecimalNumbersBinary
{

    static void HexaToBinary(string hex)
    {
        int size = hex.Length;
        char[] charArray = new char[size];
        for (int i = 0; i < size; i++)
        {
            charArray[i] = hex[i];
        }

        string binary = HexTable(charArray, size);
        Console.WriteLine(binary);

    }
    static string HexTable(char[] arr, int size)
    {
        string binary = null;
        for (int i = 0; i < size; i++)
			{
			    switch (arr[i])
                {
                    case '0':binary += "0"; break;
                    case '1':binary += "1"; break;
                    case '2':binary += "10"; break;
                    case '3':binary += "11"; break;
                    case '4':binary += "100"; break;
                    case '5':binary += "101"; break;
                    case '6':binary += "110"; break;
                    case '7':binary += "111"; break;
                    case '8':binary += "1000"; break;
                    case '9':binary += "1001"; break;
                    case 'A':binary += "1010"; break;
                    case 'B':binary += "1011"; break;
                    case 'C':binary += "1100"; break;
                    case 'D':binary += "1101"; break;
                    case 'E':binary += "1110"; break;
                    case 'F':binary += "1111"; break;
                    default: binary+= ""; break;
                }
			}
        return binary;
    }
      
    static void Main()
    {
        Console.WriteLine("Enter hexadecimal number:");
        string hexadecimal = Console.ReadLine().ToUpper();

        HexaToBinary(hexadecimal);
    }
}

