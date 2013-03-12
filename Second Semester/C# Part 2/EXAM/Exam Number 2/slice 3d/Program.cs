using System;

class Program
{
    static void Main(string[] args)
    {
        string size = Console.ReadLine();
        string[] arr = size.Split(' ');
        size.Split(' ');
        int width = int.Parse(arr[0]);
        int height = int.Parse(arr[1]);
        int depth = int.Parse(arr[2]);

        int[, ,] cube = new int[width, height, depth];

        for (int i = 0; i < height; i++)
        {
            string line = Console.ReadLine();
            string[] get = line.Split('|');
            for (int d = 0; d < depth; d++)
            {
                string[] numbers = get[d].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int w = 0; w < width; w++)
                {
                    int value = int.Parse(numbers[w]);
                    cube[w, i, d] = value;
                }
            }
        }

        long totalSum = 0;
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {

                for (int d = 0; d < depth; d++)
                {
                    totalSum += cube[i, j, d];
                }
            }
        }

        long sum = 0;
        int count = 0;
        for (int i = 0; i < width -1; i++)
        {

            for (int j = 0; j < height; j++)
            {
                for (int d = 0; d < depth; d++)
                {
                    sum += cube[i, j, d];
                }
            }

            if ((sum+sum) == totalSum)
            {
                count++;
            }

        }

        sum = 0;
        for (int i = 0; i < height-1; i++)
        {

            for (int j = 0; j < width; j++)
            {
                for (int d = 0; d < depth; d++)
                {
                    sum += cube[j, i, d];
                }
            }

            if ((sum + sum) == totalSum)
            {
                count++;
            }

        }

        sum = 0;

        for (int d = 0; d < depth-1; d++)
        {

            for (int j = 0; j < width; j++)
            {
                for (int i = 0; i < height; i++)
                {
                    sum += cube[j, i, d];
                }
            }

            if ((sum + sum) == totalSum)
            {
                count++;
            }

        }

        Console.WriteLine(count);
    }
}

