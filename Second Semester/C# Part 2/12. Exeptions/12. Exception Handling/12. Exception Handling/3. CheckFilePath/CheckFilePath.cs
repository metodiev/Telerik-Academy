using System;
using System.IO;
using System.Security;

//Write a program that enters file name along with its full file path 
//(e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the
//console. Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

class CheckFilePath
{
    static void Main()
    {
        Console.WriteLine("Enter file path:");
        string path = Console.ReadLine();

        try
        {
            string file = File.ReadAllText(path);
            Console.WriteLine("File content:\n" + file);
        }

        catch (ArgumentException)
        {
            Console.WriteLine("Path contains one or more invalid characters");
        }

        catch (PathTooLongException)
        {
            Console.WriteLine("The length of path is too big, please enter short path to file");

        }

        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path you enter is not valid");

        }
        catch (IOException)
        {
            Console.WriteLine("An input/outpu error occurred while opening the file, please try again.");
        }

        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("This operation is not supported on the current platform.");
        }
            
        catch (NotSupportedException)
        {
            Console.WriteLine("path is in an invalid format.");
        }

        catch (SecurityException)
        {
            Console.WriteLine("You do not have the required permission");
        }

    }
}

