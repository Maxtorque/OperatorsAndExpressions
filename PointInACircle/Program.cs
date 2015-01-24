using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInACircle
{
    class Program
    {
        static void Main()
        {
            Console.Write(" X : ");
            double x = double.Parse(Console.ReadLine());
            Console.Write(" Y : ");
            double y = double.Parse(Console.ReadLine());
            double radius = 2;
            double diametur = radius * radius;
            if ((x * x) + (y * y) <= diametur)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
