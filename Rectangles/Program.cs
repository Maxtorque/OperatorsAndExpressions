using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Program
    {
        static void Main()
        {
            double height, wight;
            Console.Write("Enter the height of the rectange:");
            bool isValidHeight = double.TryParse(Console.ReadLine(), out height);
            Console.Write("Enter the wight of the rectange:");
            bool isValidWight = double.TryParse(Console.ReadLine(), out wight);
            if (isValidHeight && isValidHeight)
            {
                double area = height * wight;
                Console.WriteLine("The area of the rectange is:{0}", area);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}
