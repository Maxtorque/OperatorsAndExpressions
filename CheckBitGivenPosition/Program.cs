using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBitGivenPosition
{
    class Program
    {
        static void Main()
        {
            Console.Write("n :");
            int n = int.Parse(Console.ReadLine());
            Console.Write("p :");
            int p = int.Parse(Console.ReadLine());
            int c = 1;
            int mask = c << p;
            int reslt = mask & n;
            bool isTrue = (reslt != 0);
            Console.WriteLine(isTrue);
            }
        }
    }

