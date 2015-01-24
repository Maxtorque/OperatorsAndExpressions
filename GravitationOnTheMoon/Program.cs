using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravitationOnTheMoon
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter weight: ");
            double weightOnTheEarth = double.Parse(Console.ReadLine());
            double gravityRatio = 0.17;
            double weightOnTheMoon = weightOnTheEarth * gravityRatio;
            Console.WriteLine("Weight on the Earth: {0}\nWeight on the Moon: {1}", weightOnTheEarth, weightOnTheMoon);
        }
    }
}
