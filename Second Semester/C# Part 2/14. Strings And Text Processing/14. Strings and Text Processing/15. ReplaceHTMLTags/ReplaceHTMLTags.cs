﻿using System;
using System.Text;
using System.Text.RegularExpressions;
//Write a program that replaces in a HTML document given as string all the tags 
//<a href="…">…</a> with corresponding tags [URL=…]…/URL]. Sample HTML fragment:

//<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose 
//a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>

//<p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose 
//a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

class ReplaceHTMLTags
{
    static void Main()
    {
        string str = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        string url = null;
        url =  str.Replace(@"<a href=""", "[URL=");
        url = url.Replace(@"</a>", "[/URL]");
        url = url.Replace(@""">", "]");
        Console.WriteLine(url);

    }
}

