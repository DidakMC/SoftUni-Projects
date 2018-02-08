using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string leapORnot = Console.ReadLine();
            double P = double.Parse(Console.ReadLine()); //broi praznizi
            double h = double.Parse(Console.ReadLine()); // weekends in home City

            var weekendAll = 48;
            double result = 0;

            if (leapORnot =="normal")
            {
                result = h + (weekendAll - h) * 3 / 4 + P * 2 / 3;
            }
            else if (leapORnot =="leap")
            {
                result = (h + (weekendAll - h) * 3 / 4 + P * 2 / 3)*1.15;
            }
            Console.WriteLine(Math.Floor(result));
        }
    }
}
