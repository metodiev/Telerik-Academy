using System;

//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum. Example:
// string = "43 68 9 23 318"  result = 461

namespace _6.SumOfString
{
    class SumOfString
    {
        private static int CalculateSumOfString(string numbers)
        {
            char[] charArray = numbers.ToCharArray();
            char[] sumNumbers = new char[numbers.Length];
            int sum = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i]!=' ')
                {
                    sumNumbers[i] = charArray[i];
                    sum += ConvertToInt(sumNumbers[i]);
                }
            }
                      
            return sum;
        }

        private static int ConvertToInt(char sumNumbers)
        {
            int sum = 0;
            int number = 0;
            for (int i = 48, j=0; i < 58; i++, j++)
            {
                if (sumNumbers == i)
                {
                    number = j;
                    sum += j;
                }
            }

            return sum;
        }

        static void Main()
        {
            Console.WriteLine("Enter string:");
            string numbers = Console.ReadLine();
            int sum = 0;
            sum = CalculateSumOfString(numbers);
            Console.WriteLine(sum);
        }
    }
}
