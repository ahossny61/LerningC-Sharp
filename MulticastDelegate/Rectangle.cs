using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    public class Rectangle
    {
        public Rectangle()
        {

        }
        public void GetArea(int width, int height)
        {
            Console.WriteLine($"Area = {width} * {height} = {width * height}");
            Console.WriteLine("\n");
        }

        public void GetPerimeter(int width, int height)
        {
            Console.WriteLine($"Perimeter = 2 * ( {width} + {height} ) = {2 * (width + height)}");
            Console.WriteLine("\n");
        }

    }
}
