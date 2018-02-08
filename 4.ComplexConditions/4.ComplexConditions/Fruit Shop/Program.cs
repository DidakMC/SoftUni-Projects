using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string dayOfWeek = Console.ReadLine().ToLower();
            double quanity = double.Parse(Console.ReadLine());
            double totalPrice = 0;

            if (dayOfWeek =="monday"|| 
                dayOfWeek == "tuesday" || 
                dayOfWeek == "wednesday" || 
                dayOfWeek == "thursday" || 
                dayOfWeek == "friday")
            {
                if (fruit== "banana")
                {
                    totalPrice = quanity * 2.50;
                }
                else if (fruit == "apple")
                {
                    totalPrice = quanity * 1.20;
                }
                else if (fruit == "orange")
                {
                    totalPrice = quanity * 0.85;
                }
                else if (fruit == "grapefruit")
                {
                    totalPrice = quanity * 1.45;
                }
                else if (fruit == "kiwi")
                {
                    totalPrice = quanity * 2.70;
                }
                else if (fruit == "pineapple")
                {
                    totalPrice = quanity * 5.50;
                }
                else if (fruit == "grapes")
                {
                    totalPrice = quanity * 3.85;
                }
               
            }
            else if (dayOfWeek == "saturday" || dayOfWeek == "sunday")
            {
                if (fruit == "banana")
                {
                    totalPrice = quanity * 2.70;
                }
                else if (fruit == "apple")
                {
                    totalPrice = quanity * 1.25;
                }
                else if (fruit == "orange")
                {
                    totalPrice = quanity * 0.90;
                }
                else if (fruit == "grapefruit")
                {
                    totalPrice = quanity * 1.60;
                }
                else if (fruit == "kiwi")
                {
                    totalPrice = quanity * 3.00;
                }
                else if (fruit == "pineapple")
                {
                    totalPrice = quanity * 5.60;
                }
                else if (fruit == "grapes")
                {
                    totalPrice = quanity * 4.20;
                }
            }
            if (totalPrice ==0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("{0:f2}",totalPrice);
            }
        }
    }
}
