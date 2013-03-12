using System;

class NullValuesOnIntAndDouble
{
    static void Main()
    {
        int? firstValue = null;
        Console.WriteLine(firstValue);
        double? secondValue = null;
        Console.WriteLine(secondValue);

        firstValue = 5;
        secondValue = 100;
        Console.WriteLine("{0}, {1}", firstValue, secondValue);

    }
}

