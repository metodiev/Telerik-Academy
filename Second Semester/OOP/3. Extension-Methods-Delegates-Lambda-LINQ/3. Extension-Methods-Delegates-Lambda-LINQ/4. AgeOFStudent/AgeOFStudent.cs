//
//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.AgeOFStudent
{
    class AgeOFStudent
    {
        static void Main(string[] args)
        {
            Students [] student = 
            {
                new Students("Fistname", "Lastname", 12),
                new Students("Fistname", "Lastname", 13),
                new Students("Fistname", "Lastname", 14),
                new Students("Fistname", "Lastname", 15),
                new Students("Fistname", "Lastname", 19),
                new Students("Fistname", "Lastname", 24),
            };

        }
    }
}
