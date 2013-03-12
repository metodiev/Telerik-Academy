using System;

//* Write a program that converts a number in the range [0...999] to
//a text corresponding to its English pronunciation. Examples:
//    0  "Zero"
//    273  "Two hundred seventy three"
//    400  "Four hundred"
//    501  "Five hundred and one"
//    711  "Seven hundred and eleven"


class ConvertNumberToText
{
    static void Main()
    {
        int n;
        n = 1001;
        int [] numbers = new int [n];
        string [] pronunciation = new string [n];

        pronunciation[0] = "zero";
        pronunciation[1] = "one";
        pronunciation[2] = "two";
        pronunciation[3] = "three";
        pronunciation[4] = "four";
        pronunciation[5] = "five";
        pronunciation[6] = "six";
        pronunciation[7] = "seven";
        pronunciation[8] = "eight";
        pronunciation[9] = "nine";
        pronunciation[10] = "ten";
        pronunciation[11] = "eleven";
        pronunciation[12] = "twelve";
        pronunciation[13] = "thirteen";
        pronunciation[14] = "fourteen";
        pronunciation[15] = "fifteen";
        pronunciation[16] = "sixteen";
        pronunciation[17] = "seventeen";
        pronunciation[18] = "eigteen";
        pronunciation[19] = "nineteen";
        pronunciation[20] = "twenty";

        pronunciation[30] = "thirty";
        pronunciation[40] = "forty";
        pronunciation[50] = "fifty";
        pronunciation[60] = "sixty";
        pronunciation[70] = "seventy";
        pronunciation[80] = "eighty";
        pronunciation[90] = "ninety";
        pronunciation[100] = "hundred";

        string [] numbersTwenty = new string[10];

        for (int i = 1; i < 10; i++)
        {
            numbersTwenty[i] = pronunciation[i];
        }

        for (int j = 21, i = 1; i < 10; j++, i++)
        {
            pronunciation[j] = pronunciation[20] + " " + numbersTwenty[i];
        }

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

        string[] hundredNumbers = new string [101];

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
  
        Console.WriteLine("Enter number between 0 and 999");
        int number;
        number = int.Parse(Console.ReadLine());
        Console.WriteLine(pronunciation[number]);
    }
}

