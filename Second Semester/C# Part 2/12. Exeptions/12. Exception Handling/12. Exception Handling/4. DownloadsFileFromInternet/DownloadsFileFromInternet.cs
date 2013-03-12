//Write a program that downloads a file from Internet 
//(e.g. http://www.devbg.org/img/Logo-BASD.jpg) and
//stores it the current directory. Find in Google how
//to download files in C#. Be sure to catch all exceptions 
//and to free any used resources in the finally block.

using System;
using System.Net;

class DownloadsFileFromInternet
{
    static void Main()
    {
        using (WebClient client = new WebClient())
        { 
           // Client.DownloadFile("http://i.stackoverflow.com/Content/Img/stackoverflow-logo-250.png", @"C:\folder\stackoverflowlogo.png");
            try
            {
                client.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "../../logo.jpg");
            }

            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid address:");
            }

            catch (WebException)
            {
                Console.Error.WriteLine("inalid address or empty file:");
            }

            catch (NotSupportedException)
            {
                Console.Error.WriteLine("The method has been called simultaneously on multiple threads.");
            }

            finally
            {
                client.Dispose();
            }
        }
    }
}

