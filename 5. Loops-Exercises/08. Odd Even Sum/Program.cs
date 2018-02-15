using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    int num = int.Parse(Console.ReadLine());
                    evenSum += num;
                }
                else
                {
                    int num = int.Parse(Console.ReadLine());
                    oddSum += num;
                }
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine($"Yes, sum = {evenSum }");
            }
            else
            {
                int diff = Math.Abs(oddSum - evenSum);
                Console.WriteLine($"No, diff = {diff}");

            }
        }
    }    }
