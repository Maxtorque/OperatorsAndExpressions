using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter the number:");
            bool isInt = int.TryParse(Console.ReadLine(), out number);
            if (isInt)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is even");
                }
                else
                {
                    Console.WriteLine("The number is odd");
                }
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}
