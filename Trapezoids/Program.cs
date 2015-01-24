using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoids
{
    class Program
    {
        static void Main()
        {
            double a, b, h;
            Console.Write("Enter the first side of the trapezoid:");
            bool isValid_a = double.TryParse(Console.ReadLine(), out a);
            Console.Write("Enter the second side of the trapezoid:");
            bool isValid_b = double.TryParse(Console.ReadLine(), out b);
            Console.Write("Enter the height of the trapezoid:");
            bool isValid_h = double.TryParse(Console.ReadLine(), out h);

            if (isValid_a && isValid_b && isValid_h)
            {
                double area = (a + b) * 0.5 * h;
                Console.WriteLine("The area of the rectange is:{0}", area);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}
