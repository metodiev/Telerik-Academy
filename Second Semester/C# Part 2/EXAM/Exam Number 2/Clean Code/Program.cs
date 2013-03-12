using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace strings
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();
            string strReversed = "";

            foreach (char c in str)
            {
                strReversed = c + strReversed;
            }

            Console.WriteLine("{0} -> {1}", str, strReversed);
        }
    }
}





//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;


//namespace Clean_Code
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
            
//            int N = int.Parse(Console.ReadLine());
//            string[] str = new string[N];

//            for (int i = 0; i < N; i++)
//            {
//                str[i] = Console.ReadLine();
//            }


//            var re = @"((?:""[^""]*"")+|""(?:[^""\n\\]+|\\.)*""|'(?:[^'\n\\]+|\\.)*')|//.*|/\*(?s:.*?)\*/";
   

//           // var regex = new Regex("/\*((?!\*/).)*\*/", RegexOptions.Singleline);
//            string[] str1 = new string [N];
//            for (int i = 0; i < N; i++)
//            {
//                 str1[i] = Regex.Replace(str[i], re, "$1");
//                 str1[i] = Regex.Replace(str1[i], "\n", "");
//            }

//            for (int i = 0; i < N; i++)
//            {
//                Console.WriteLine(str1[i]);
//            }
                
//        }
//    }
//}
