using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine().ToLower();
            string result = null;

            if (age<16)
            {
                if (gender=="f")
                {
                    result = "Miss";
                }
                if (gender=="m")
                {
                    result = "Master";
                }
            }
            else
            {
                if (gender == "f")
                {
                    result = "Ms.";
                }
                if (gender == "m")
                {
                    result = "Mr.";
                }
            }
            Console.WriteLine(result);
        }
    }
}
