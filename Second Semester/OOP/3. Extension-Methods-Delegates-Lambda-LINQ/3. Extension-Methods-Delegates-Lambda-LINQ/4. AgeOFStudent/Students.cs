//
//Write a LINQ query that finds the first name and 
//last name of all students with age between 18 and 24.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Students
{
    //fields
    private  string firstName;
    private string lastName;
    private byte age;

    //constructor
    public Students(string first, string second, byte age)
    {
        this.firstName = first;
        this.lastName = second;
        this.age = age;
    }

    //property firstName
    public string FirstName
    {
        get { return this.firstName; }
        set { this.firstName = value; }
    }

    //property secondName
    public string LastName
    {
        get { return this.lastName; }
        set { this.lastName = value; }
    }

    //property Age
    public byte Age
    {
        get { return this.age;}
        set { this.age = value; }
    }

    //LINQ query that finds the first name and last name of all students 
    //with age between 18 and 24
    public static Students[] FirstNameLastNameAlpha(Students []students)
    {
        int count = 0;

        var adult =
                from st in students
                where st.Age >= 18 && st.Age <= 24
                select (st);

        foreach (var st in adult)
        {
            Console.WriteLine("{0}, {1}, {2}", st.FirstName, st.LastName, st.Age);
        }
        return students;

          
    }
}

    

