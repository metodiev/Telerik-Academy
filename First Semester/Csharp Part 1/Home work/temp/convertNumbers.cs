using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace convertNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0, a = 0, n = 1001;
            int[] numbers = new int[n];
            string[] numbersTwenty = new string[10];
            string[] pronunciation = new string[n];
            string[] hundredNumbers = new string[101];
            for (int i = 0; i <= 1000; i++)
            {
                numbers[i] = i;

            }

            pronunciation[a] = "zero";
            ++a;
            pronunciation[a] = "one";

            ++a;
            pronunciation[a] = "two";
            ++a;
            pronunciation[a] = "three";
            ++a;
            pronunciation[a] = "four";
            ++a;
            pronunciation[a] = "five";
            ++a;
            pronunciation[a] = "six";
            ++a;
            pronunciation[a] = "seven";
            ++a;
            pronunciation[a] = "eight";
            ++a;
            pronunciation[a] = "nine";
            ++a;
            pronunciation[a] = "ten";
            ++a;
            pronunciation[a] = "eleven";
            ++a;
            pronunciation[a] = "twelve";
            ++a;

            pronunciation[a] = "thirteen";
            ++a;
            pronunciation[a] = "fourteen";
            ++a;
            pronunciation[a] = "fifteen";
            ++a;
            pronunciation[a] = "sixteen";
            ++a;
            pronunciation[a] = "seventeen";
            ++a;
            pronunciation[a] = "eighteen";
            ++a;
            pronunciation[a] = "nineteen";
            ++a;
            pronunciation[a] = "twenty";

            for (int i = 1; i < 10; i++)
            {
                numbersTwenty[i] = pronunciation[i];

            }
            for (int j = 21, i = 1; i < 10; j++, i++)
            {
                pronunciation[j] = pronunciation[a] + " " + numbersTwenty[i];

            }

            pronunciation[30] = "thirty";
            pronunciation[40] = "forty";
            pronunciation[50] = "fifty";
            pronunciation[60] = "sixty";
            pronunciation[70] = "seventy";
            pronunciation[80] = "eighty";
            pronunciation[90] = "ninety";
            pronunciation[100] = "hundred";
            for (int j = 31, i = 1; i < 10; j++, i++)
            {
                pronunciation[j] = pronunciation[30] + " " + numbersTwenty[i];

            }

            for (int j = 41, i = 1; i < 10; j++, i++)
            {
                pronunciation[j] = pronunciation[40] + " " + numbersTwenty[i];

            }
            for (int j = 51, i = 1; i < 10; j++, i++)
            {
                pronunciation[j] = pronunciation[50] + " " + numbersTwenty[i];

            }
            for (int j = 61, i = 1; i < 10; j++, i++)
            {
                pronunciation[j] = pronunciation[60] + " " + numbersTwenty[i];

            }
            for (int j = 71, i = 1; i < 10; j++, i++)
            {
                pronunciation[j] = pronunciation[70] + " " + numbersTwenty[i];

            }

            for (int j = 81, i = 1; i < 10; j++, i++)
            {
                pronunciation[j] = pronunciation[80] + " " + numbersTwenty[i];

            }

            for (int j = 91, i = 1; i < 10; j++, i++)
            {
                pronunciation[j] = pronunciation[90] + " " + numbersTwenty[i];

            }
            for (int i = 1; i < 100; i++)
            {
                hundredNumbers[i] = pronunciation[1] + " " + pronunciation[100] + " and " + pronunciation[i];

            }
            for (int j = 101, i = 1; i < 100; j++, i++)
            {
                pronunciation[j] = hundredNumbers[i];

            }
            for (int j = 200, i = 0; i < 100; j++, i++)
            {
                pronunciation[j] = pronunciation[2] + " hundred and" + " " + pronunciation[i];
            }
            for (int j = 300, i = 0; i < 100; j++, i++)
            {
                pronunciation[j] = pronunciation[3] + " hundred and" + " " + pronunciation[i];
            }

            for (int j = 400, i = 0; i < 100; j++, i++)
            {
                pronunciation[j] = pronunciation[4] + " hundred and" + " " + pronunciation[i];
            }
            for (int j = 500, i = 0; i < 100; j++, i++)
            {
                pronunciation[j] = pronunciation[5] + " hundred and" + " " + pronunciation[i];
            }
            for (int j = 600, i = 0; i < 100; j++, i++)
            {
                pronunciation[j] = pronunciation[6] + " hundred and" + " " + pronunciation[i];
            }
            for (int j = 700, i = 0; i < 100; j++, i++)
            {
                pronunciation[j] = pronunciation[7] + " hundred and" + " " + pronunciation[i];
            }
            for (int j = 800, i = 0; i < 100; j++, i++)
            {
                pronunciation[j] = pronunciation[8] + " hundred and" + " " + pronunciation[i];
            }
            for (int j = 900, i = 0; i < 100; j++, i++)
            {
                pronunciation[j] = pronunciation[9] + " hundred and" + " " + pronunciation[i];
            }
            Console.WriteLine("Enter the number you wish\n");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(pronunciation[number]);
        }
    }
}
