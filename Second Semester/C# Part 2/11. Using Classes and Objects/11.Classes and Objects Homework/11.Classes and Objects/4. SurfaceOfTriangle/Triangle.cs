using System;

namespace _4.SurfaceOfTriangle
{
    class Triangle
    {
        private static void CalcWithAltitude()
        {
            Console.WriteLine("Enter altitude of triangle:");
            double altitude = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a side:");
            double side = double.Parse(Console.ReadLine());
            double surface;
            surface = (side * altitude) / (2);
            Console.WriteLine("{0:F3}", surface);
        }

        private static void CaclWithSides()
        {
            Console.WriteLine("Entre three sides of triangle:");
            double firstSide = double.Parse(Console.ReadLine());
            double secondSide = double.Parse(Console.ReadLine());
            double thirdSide = double.Parse(Console.ReadLine());
            double p = (firstSide + secondSide + thirdSide) / (2);
            double surface = Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
            Console.WriteLine("{0:F3}", surface);

        }

        private static void CalcWithAngle()
        {
            Console.WriteLine("Enter two sides of triangle");
            double firstSide = double.Parse(Console.ReadLine());
            double secondSide = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter angle of triangle:");
            double angle = double.Parse(Console.ReadLine());
            double surface;
            surface = ((firstSide * secondSide) * (Math.Sin(Math.PI * (angle / 180)))) / (2);
            Console.WriteLine(surface);
           
        }

        static void Main()
        {
            Console.WriteLine("\t Menu:");
            Console.WriteLine("How you want to calculate the surface of a triangle:");
            Console.WriteLine("1. Enter altitude ");
            Console.WriteLine("2. Enter three sides");
            Console.WriteLine("3. Two sides and an angle between them");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: CalcWithAltitude(); break;
                case 2: CaclWithSides(); break;
                case 3: CalcWithAngle(); break;

                default:
                    break;
            }
        }
    }
}
