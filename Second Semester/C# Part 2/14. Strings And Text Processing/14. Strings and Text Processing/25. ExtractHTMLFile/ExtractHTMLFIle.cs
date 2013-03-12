using System;
using System.Text;
using System.Text.RegularExpressions;

//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. Example:
//html>
//  <head><title>News</title></head>
//  <body><p><a href="http://academy.telerik.com">Telerik
//    Academy</a>aims to provide free real-world practical
//    training for young people who want to turn into
//    skillful .NET software engineers.</p></body>
//</html>


class ExtractHTMLFIle
{
    static void Main()
    {
        string html = "<html><head><title>News</title></head><body><p><a href=http://academy.telerik.com>TelerikAcademy</a>aims to provide free real-world practicaltraining for young people who want to turn int skillful .NET software engineers.</p></body></html>";
      
        Console.WriteLine("Title:" + GetTitle(html));
        Console.WriteLine((GetBody(html)));
        Console.ReadLine();
    }

    static string GetTitle(string file)
    {
        Match title = Regex.Match(file, @"<title>\s*(.+?)\s*</title>");
        if (title.Success)
        {
            return title.Groups[1].Value;
        }

        else
        {
            return "";
        }
    }


    static string GetBody(string file)
    {
        Match title = Regex.Match(file, @"<body>\s*(.+?)\s*</body>|");
        if (title.Success)
        {
            return title.Groups[1].Value;
        }

        else
        {
            return "";
        }
    }
}

