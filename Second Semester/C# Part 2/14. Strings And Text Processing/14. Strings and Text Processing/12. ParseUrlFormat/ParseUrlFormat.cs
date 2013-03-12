using System;
using System.Text;
using System.Text.RegularExpressions;

//Write a program that parses an URL address given in the format:
//[protocol]://[server]/[resource]

//and extracts from it the [protocol], [server] and [resource] elements. For example 
//from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//        [protocol] = "http"
//        [server] = "www.devbg.org"
//        [resource] = "/forum/index.php"

class ParseUrlFormat
{
    static void Main()
    {
        string str = "http://www.devbg.org/forum/index.php";
        string protocol = Regex.Match(str, "[^:]*" ).ToString();
        string server = Regex.Match(str, @"/([^/][\w\.]*)").ToString();
        string resourse = Regex.Match(str, @"\b/[^/][\w.]*.+").ToString();
        Console.WriteLine("[protocol:]"+protocol);
        Console.WriteLine("[server]"+ server);
        Console.WriteLine("[resourse]"+ resourse);
    }
}

