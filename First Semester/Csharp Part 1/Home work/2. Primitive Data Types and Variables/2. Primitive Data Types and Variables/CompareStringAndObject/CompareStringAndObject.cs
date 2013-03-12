using System;

class CompareStringAndObject
{
    static void Main()
    {
        string word = "Hello World";
        object helloObj = "Hello" + " " + "World";
        string assignedObj = helloObj.ToString();
        Console.WriteLine("string content: {0}\nobject content: {1}\nString that assigned with object content: {2}", word, helloObj, assignedObj);
    }
}

