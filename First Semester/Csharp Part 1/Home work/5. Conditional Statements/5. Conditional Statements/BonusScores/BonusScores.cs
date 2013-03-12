using System;

//Write a program that applies bonus scores to given scores in the range [1..9]. 
//The program reads a digit as an input. If the digit is between 1 and 3,
//the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100;
//if it is between 7 and 9, multiplies it by 1000. If it is zero or if 
//the value is not a digit, the program must report an error.
//Use a switch statement and at the end print the calculated new value in the console.

class BonusScores
{
    static void Main()
    {
        Console.WriteLine("Enter digit between 1 and 9");
        int choice;
        choice = int.Parse(Console.ReadLine());
        
        switch(choice)
        {
            case 1: int multiplyByTen;
                    multiplyByTen = choice * 10;
                    Console.WriteLine(multiplyByTen);
                    break;

            case 2: multiplyByTen = choice * 10;
                    Console.WriteLine(multiplyByTen);
                    break;

            case 3: multiplyByTen = choice * 10;
                    Console.WriteLine(multiplyByTen);
                    break;

            case 4: int multiplyByHundred;
                    multiplyByHundred = choice * 100;
                    Console.WriteLine(multiplyByHundred);
                    break;

            case 5: multiplyByHundred = choice * 100;
                    Console.WriteLine(multiplyByHundred);
                    break;

            case 6: multiplyByHundred = choice * 100;
                    Console.WriteLine(multiplyByHundred);
                    break;

            case 7: int multiplyByThousand;
                    multiplyByThousand = choice * 1000;
                    Console.WriteLine(multiplyByThousand);
                    break;

            case 8: multiplyByThousand = choice * 1000;
                    Console.WriteLine(multiplyByThousand);
                    break;

            case 9: multiplyByThousand = choice * 1000;
                    Console.WriteLine(multiplyByThousand);
                    break;

            default: Console.WriteLine("Eror: entered choice is wrong");
                    break;
        }
    }
}

