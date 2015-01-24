using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBitInteger
{
    class Program
    {
        static void Main()
        {
            byte value = 0;
            int n;
            byte p;
            Console.Write("Enter the integer number i:");
            bool isiInt = int.TryParse(Console.ReadLine(), out n);
            Console.Write("Enter the position of the bit b:");
            bool isbByte = byte.TryParse(Console.ReadLine(), out p);

            if (isiInt && isbByte && p < 32)
            {
                int mask = 1 << p;
                if ((n & mask) == mask)
                {
                    value = 1;
                }
                Console.WriteLine("value={0}", value);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}
