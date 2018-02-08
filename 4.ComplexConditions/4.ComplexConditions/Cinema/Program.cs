using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine().ToLower();
            int row=int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            switch (typeProjection )
            {
                case "premiere":
                    totalPrice = row * column * 12;
                    break;
                case "normal":
                    totalPrice = row * column * 7.50;
                    break;
                case "discount":
                    totalPrice = row * column * 5;
                    break;
            }
            Console.WriteLine("{0:f2}",totalPrice );
        }
    }
}
