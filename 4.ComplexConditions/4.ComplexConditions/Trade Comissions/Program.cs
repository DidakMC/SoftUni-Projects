using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double sells = double.Parse(Console.ReadLine());
            double comission = 0;
            

            if (sells>=0 && sells<=500)
            {
                if (town=="sofia")
                {
                    comission = 0.05;
                }
                else if (town=="varna")
                {
                    comission = 0.045;
                }
                else if (town=="plovdiv")
                {
                    comission = 0.055;
                }
            }
            else if (sells<=1000)
            {
                if (town == "sofia")
                {
                    comission = 0.07;
                }
                else if (town == "varna")
                {
                    comission = 0.075;
                }
                else if (town == "plovdiv")
                {
                    comission = 0.08;
                }
            }
            else if (sells <=10000)
            {
                if (town == "sofia")
                {
                    comission = 0.08;
                }
                else if (town == "varna")
                {
                    comission = 0.10;
                }
                else if (town == "plovdiv")
                {
                    comission = 0.12;
                }
            }
            else if (sells >10000)
            {
                if (town == "sofia")
                {
                    comission = 0.12;
                }
                else if (town == "varna")
                {
                    comission = 0.13;
                }
                else if (town == "plovdiv")
                {
                    comission = 0.145;
                }
            }
            double comissionProfit = comission * sells;
            if (comissionProfit>0)
            {
               
                Console.WriteLine("{0:f2}",comissionProfit );
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
