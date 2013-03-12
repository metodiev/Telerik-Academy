using System;

//We are given a matrix of strings of size N x M. 
//Sequences in the matrix we define as sets of several 
//neighbor elements located on the same line, column or
//diagonal. Write a program that finds the longest
//sequence of equal strings in the matrix.

class SequencesInTheMatrix
{
    private static string[] CheckVertical(string [,] matrix)
    {
        int checkVertical = 1;
        int checkVerticalMax = 1;
        string vertical = null;

        
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    checkVertical++;
                    if (checkVertical >= checkVerticalMax)
                    {
                        vertical = matrix[row, col];
                        checkVerticalMax = checkVertical;
                    }
                }

                else
                {
                    checkVertical = 1;
                }
            }
        }
        string [] arr = new string[2];
        arr[0] = vertical;
        arr[1] = checkVerticalMax.ToString();
        return arr;
    }


    private static string [] CheckHorisontal(string[,] matrix)
    {
        int horisont = 1;
        int maxHorisont = 1;
        string horisontal = null;
        
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    horisont++;
                    if (horisont >= maxHorisont)
                    {
                        horisontal = matrix[row, col];
                        maxHorisont = horisont;
                    }
                }

                else
                {
                    horisont = 1;
                }
            }
        }
        string[] arr = new string[2];
        arr[0] = horisontal;
        arr[1] = maxHorisont.ToString();
        return arr;
    }

    private static string [] CheckRightDiagonal(string[,] matrix)
    {
        int rightDiagonal = 1;
        int rightDiagonalMax = 1;
        string diagonalR = null;

        
        for (int row = 0; row <= matrix.GetLength(0); row++)
        {
            for (int col = 0; col <= matrix.GetLength(1); col++)
            {
                if (col >= matrix.GetLength(1) - 1 || row >= matrix.GetLength(0) - 1)
                {
                    break;
                }
                else
                {
                    while (col < matrix.GetLength(1) - 1 && row < matrix.GetLength(0) - 1)
                    {
                        if (matrix[row, col] == matrix[row + 1, col + 1])
                        {
                            rightDiagonal++;

                            if (rightDiagonal >= rightDiagonalMax)
                            {
                                diagonalR = matrix[row, col];
                                rightDiagonalMax = rightDiagonal;
                            }

                            row++;
                            col++;
                        }

                        else
                        {
                            rightDiagonal = 1;
                            break;
                        }

                    }
                    rightDiagonal = 1;
                }
            }
        }

        string[] arr = new string[2];
        arr[0] = diagonalR;
        arr[1] = rightDiagonalMax.ToString();
        return arr;
    }

    private static string []CheckLeftDiagonal(string[,] matrix)
    {
        int leftDiagonalMax = 1;
        int leftDiagonal = 1;
        string diagonalLeft = null;
       
        for (int row = 0; row <= matrix.GetLength(0); row++)
        {
            for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
            {
                if (col <= 1 || row >= matrix.GetLength(0) - 1)
                {
                    break;
                }

                else
                {
                    while (col > 0 && row < matrix.GetLength(0) - 1) //Move to Diagonal
                    {
                        if (matrix[row, col] == matrix[row + 1, col - 1]) //If finde same elements continue Move to Diagonal
                        {
                            leftDiagonal++;

                            if (leftDiagonal >= leftDiagonalMax)
                            {
                                diagonalLeft = matrix[row, col];
                                leftDiagonalMax = leftDiagonal;
                            }

                            row++;
                            col--;
                        }

                        else 
                        {
                            leftDiagonal = 1;
                            break;
                        }

                    }

                    leftDiagonal = 1;
                }
            }            
        }

        string[] arr = new string[2];
        arr[0] = diagonalLeft;
        arr[1] = leftDiagonalMax.ToString();
        return arr;
    }

    static void Main()
    {
        string[,] matrix = {
            {"ha", "fifi", "ho", "hi"},
            {"fo", "ha", "hi", "xx"},
            {"xxx", "ho", "но", "xx"},
        };

        //string[,] matrix = {
        //    {"s", "qq", "s"},
        //    {"pp", "pp", "s"},
        //    {"pp", "qq", "s"},
        //};

        string[] numbers = new string[2];
        string[] first = new string[2];
        string[] second = new string[2];
        string[] third = new string[2];
        string[] temp = new string[2];

        numbers = CheckVertical(matrix);
        first = CheckHorisontal(matrix);
        second = CheckRightDiagonal(matrix);
        third = CheckLeftDiagonal(matrix);

        int firstNumber = Convert.ToInt32(numbers[1]);
        int secondNumber = Convert.ToInt32(first[1]);
        int thirdNumber = Convert.ToInt32(second[1]);
        int fourthNumber = Convert.ToInt32(third[1]);

        int[] arr = new int[4];
        arr[0] = firstNumber;
        arr[1] = secondNumber;
        arr[2] = thirdNumber;
        arr[3] = fourthNumber;

        Array.Sort(arr);
        int endNumber = arr[3];
        string[] endString = new string[2]; 

        if (endNumber == firstNumber)
        {
            endString = numbers;
        }

        if (endNumber == secondNumber)
        {
            endString = first;
        }

        if (endNumber == thirdNumber)
        {
            endString = second;
        }

        if (endNumber == fourthNumber)
	    {
            endString = third;
	    }
        Console.WriteLine("longest sequence of equal strings in the matrix:");
        for (int i = 0; i < 2; i++)
        {
            Console.Write(endString[i]);
            Console.WriteLine();
        }
        
    }
}

