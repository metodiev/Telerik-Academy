
//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.DivisibleBy7And3
{
    class TestClass
    {
        //field
        private int[] numbers;

        //method for given numbers to print //LINQ
        public void PrintNumbers()
        { 
            int [] numbers = new int [20];
            var number = 
                from num in numbers
                where num % 21 == 0
                    select num;

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        //with lambda expression
        public void Print()
        {
            int[] numbers = new int[20];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            var selectedNums = numbers.Where(x => x % 21 == 0);

            foreach (var num in selectedNums)
            {
                Console.WriteLine(num);
            }
            
        }
    }
}
