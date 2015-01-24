using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigitIsSeven
{
    class Program
    {
        static void Main()
        {
            bool check = false;
            Console.Write("Enter the number:");
            int number;
            bool isInt = int.TryParse(Console.ReadLine(), out number);
            if (isInt)
            {
                if (number % 1000 > 699 && number % 1000 < 800)
                {
                    check = true;
                }
                Console.WriteLine("Is the third digit equal to 7?:{0}", check);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}
