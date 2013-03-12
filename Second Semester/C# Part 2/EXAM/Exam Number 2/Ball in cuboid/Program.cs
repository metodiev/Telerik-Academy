
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball_in_cuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] size = numbers.Split(' ');
            int width = int.Parse(size[0]);
            int height = int.Parse(size[1]);
            int depth = int.Parse(size[2]);

            int[, ,] ball = new int[width, height, depth];
        }
    }
}
