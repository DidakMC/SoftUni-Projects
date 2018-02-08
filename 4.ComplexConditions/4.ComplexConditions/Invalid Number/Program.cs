using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool valid = number==0 || (number >= 100 && number <= 200);

            if (!valid)
            {
                Console.WriteLine("invalid");
            }
            
        }
    }
}
