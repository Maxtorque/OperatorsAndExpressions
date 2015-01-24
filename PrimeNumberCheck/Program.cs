using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCheck
{
    class Program
    {
        static void Main()
        {
            bool isPrime = true;
            int number;
            Console.Write("Enter the number:");
            bool isInt = int.TryParse(Console.ReadLine(), out number);

            if (isInt)
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                    }
                }
                Console.WriteLine("Is this a prime number?:{0}", isPrime);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}
