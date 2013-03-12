using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class Student
{      // Method for menu of the program
    public static void SwitchMenu()
    {
        Console.WriteLine("\t1.Enter new student");
        Console.WriteLine("\t2.Read data from file");
        Console.WriteLine("\t3.Search in file");
        Console.WriteLine("\t3.Exit of program\n");
    }
    //Methods to enter the student name
    public static void EnterNameOfStudent()
    {
        Console.WriteLine("\tEnter the name of student");
        nameOfStudent = Console.ReadLine();
    }
    //Methods to enter data for student
    public static void EnterDataForStudent()
    {
        Console.WriteLine("Enter age of student\n");
        int ageOfStudent;
        //Converting string to integer
        ageOfStudent = int.Parse(Console.ReadLine());
        string age;
        age = ageOfStudent.ToString();


        Console.WriteLine("Enter course of student\n");
        int courseOfStudent;
        courseOfStudent = int.Parse(Console.ReadLine());
        string course;
        course = courseOfStudent.ToString();


        Console.WriteLine("Enter the group of student\n");
        int groupOfStudent;
        groupOfStudent = int.Parse(Console.ReadLine());
        string group;
        group = groupOfStudent.ToString();


        Console.WriteLine("Enter the fak. number of student\n");
        string fakNumberOfStudent;
        fakNumberOfStudent = Console.ReadLine();
        //Call method WriteDataToTxt to write the variables in the file
        Student.WriteDataToTxt(age, course, group, fakNumberOfStudent);
    }
    //Method to enter marks of student
    public static void EnterMarksOfStudent()
    {
        Console.WriteLine("Enter marks of student\n");
        int[] marksOfStudent = new int[25];

        Console.WriteLine("How marks you wish to enter?");
        int numberOfMarks;
        numberOfMarks = int.Parse(Console.ReadLine());
        //Enter marks for student
        for (int i = 0; i < numberOfMarks; i++)
        {
            Console.WriteLine("Enter the {0} mark of student\n", i);
            marksOfStudent[i] = int.Parse(Console.ReadLine());
        }
        //Ask user to see entered marks
        Console.WriteLine("Do you want to see wich marks you enter?...y/n");
        string key;
        key = Console.ReadLine();
        if (key == "y")
        {
            foreach (var mark in marksOfStudent)
            {
                Console.WriteLine(mark);
            }
        }
        //Open file for writing
        StreamWriter dataMarks = new StreamWriter("MarksOfStudent.txt");
        using (dataMarks)
        {
            for (int i = 0; i < numberOfMarks; i++)
            {
                dataMarks.WriteLine(
                    "Mark of student is:" + marksOfStudent[i]);
            }
        }
    }
    //Method to exit of the program
    public static void ExitOfProgram()
    {
        Console.WriteLine("To exit press ctl + c...\n");
    }

    public static string nameOfStudent { get; set; }
    //Method to Write data for student
    public static void WriteDataToTxt(string age, string course, string group, string fakNumber)
    {
        StreamWriter dataForStudent = new StreamWriter("Students.txt");
        using (dataForStudent)
        {
            dataForStudent.WriteLine("The name of student is:" + nameOfStudent);
            dataForStudent.WriteLine("Age of student are:" + age);
            dataForStudent.WriteLine("Student course:" + course);
            dataForStudent.WriteLine("Group of student is:" + group);
            dataForStudent.WriteLine("Faknumber of student is:" + fakNumber);
        }
    }
}

class DataFile
{
    public static string whichFileToOpen { get; set; }
    //Method to open file witch user entered
    public static void OpenFile()
    {
        do
        {
            Console.WriteLine(
                "Which file you want to open students or marks of student?\n"); //Ask user which file wants to open
            Console.WriteLine(
                "To open students enter students to open marks enter marks\n\n");
            whichFileToOpen = Console.ReadLine();

        } while (!((whichFileToOpen == "students") || (whichFileToOpen == "marks")));//Loop to check does the user enetered correct data

        string fileNameMarks = @"..\..\MarksOfStudent.txt";
        string fileNameStudent = @"..\..\Students.txt";
        string fileName;
        //Loop to check choice of user 
        if (whichFileToOpen == "students")
        {
            fileName = fileNameStudent;
        }
        else
        {
            fileName = fileNameMarks;
        }
        // Try to catch exeption for opening file
        try
        {
            StreamReader reader = new StreamReader(fileName);
            Console.WriteLine(
            "File {0} successfully opened.", fileName); 
            Console.WriteLine("File contents:\n");
            using (reader)
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
        catch (FileNotFoundException) 
        {
            Console.Error.WriteLine(
            "Can not find file {0}.", fileName);
        }
        catch (DirectoryNotFoundException)
        {
            Console.Error.WriteLine(
            "Invalid directory in the file path.");
        }
        catch (IOException)
        {
            Console.Error.WriteLine(
            "Can not open the file {0}", fileName);
        }
    }

}

class SearchingInFile
{
    public static string FileToSearch { get; set; }
    //Method for searching in file
    public static void SearchInFile()
    {
        do
        {
            Console.WriteLine("In wich file you wanna search students or marks of student?\n");
            Console.WriteLine("To search in students enter students to search marks enter marks\n\n");
            FileToSearch = Console.ReadLine();

        } while (!((FileToSearch == "students") || (FileToSearch == "marks")));

        string fileNameMarks = @"..\..\MarksOfStudent.txt";
        string fileNameStudent = @"..\..\Students.txt";
        string fileName;
        //Chech choice of user 
        if (FileToSearch == "students")
        {
            fileName = fileNameStudent;
        }
        else
        {
            fileName = fileNameMarks;
        }

        Console.WriteLine("Enter the search word\n");
        string enterSearchWord;
        enterSearchWord = Console.ReadLine();
        //Try to catch FileNotFindExeption and IOExeption
        try
        {
            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                int occurrences = 0;
                string line = reader.ReadLine();//Read from file
                while (line != null)
                {
                    int index = line.IndexOf(enterSearchWord);
                    while (index != -1)
                    {
                        occurrences++;
                        index = line.IndexOf(enterSearchWord, (index + 1));
                    }
                    line = reader.ReadLine();
                }
                Console.WriteLine(
                "The word {0} occurs {1} times.", enterSearchWord, occurrences);
            }
        }
        catch (FileNotFoundException)
        {
            Console.Error.WriteLine(
            "Can not find file {0}.", fileName);
        }
        catch (IOException)
        {
            Console.Error.WriteLine(
            "Can not read the file {0}.", fileName);
        }

    }
}


class StudentSystem
{   //Main function of program
    static void Main(string[] args)
    {   //Ask user to enter or exit of the menu
        Console.WriteLine("Menu:");
        Console.WriteLine("\tTo enter menu press 1:");
        Console.WriteLine("\tTo exit press ctrl + c...\n");
        Console.WriteLine("Enter a Choice...");
        //if the user enetered in the menu call method SwitchMenu
        int menuChoice;
        menuChoice = int.Parse(Console.ReadLine());
        if (menuChoice == 1)
        {
            Student.SwitchMenu();
        }

        int choice;//Deaclare variable
        choice = int.Parse(Console.ReadLine());
        switch (choice)//Switch the entered choice of user
        {
            case 1: Student.EnterNameOfStudent();
                Student.EnterDataForStudent();
                Student.EnterMarksOfStudent();
                break;
            case 2: DataFile.OpenFile();
                break;
            case 3: SearchingInFile.SearchInFile();
                break;
            default: Student.ExitOfProgram();
                break;
        }
    }
}

