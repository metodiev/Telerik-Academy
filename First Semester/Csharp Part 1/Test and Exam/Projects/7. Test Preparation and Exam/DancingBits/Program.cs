using System;

class Program
{
    static void Main()
    {
        int K = int.Parse(Console.ReadLine()); 
        int N = int.Parse(Console.ReadLine());
        string number = null;
    
    
        for (int i = 0; i < N; i++)
        {
            int numbers = int.Parse(Console.ReadLine());
            number = number + Convert.ToString(numbers, 2);
        }

        int nNumbers = number.Length;
        string temp = Convert.ToString(K,2);
        string secondTemp = temp.PadLeft(K,'0');
        Console.WriteLine(secondTemp);
        int kNumbers = secondTemp.Length;
        string mystring = number;
        string other = null;
        
        int count = 0;
        for (int i = kNumbers; i < nNumbers; i++)
        {
           other = mystring.Substring(mystring.Length - i, kNumbers);
           Console.WriteLine(other);
            if (secondTemp == other)
            {
                count++;
            }
        }
       Console.WriteLine(count);
    }
}

