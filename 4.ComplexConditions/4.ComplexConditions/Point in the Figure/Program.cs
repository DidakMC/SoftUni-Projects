using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int H = int.Parse(Console.ReadLine()); //strana na kvadrata
            int x= int.Parse(Console.ReadLine()); //koordinati na tochka
            int y = int.Parse(Console.ReadLine());

            var x1 = 0;
            var y1 = 0;
            var x2 = 3 * H;
            var y2 = H ;

            var x3 = H;
            var y3 = H;
            var x4 = 2 * H;
            var y4 = 4 * H;

            bool firstRectangle = x > x1 && x < x2 && y > y1 && y < y2;
            bool secondRectangle = x > x3 && x < x4 && y > y3 && y < y4;
            bool commonSide = x > x3 && y == H && x<2*H ;
            bool sidesfirst = y == 0 && x >= x1 && x <= x2 || y == H  && x >= x1 && x <= x2||x==0&&y>0&&y<H|| x == 3*H  && y > 0 && y <= H;
            bool sidesSecond = x == H && y >= H && y <= y4 || x == 2 * H && y >= H && y <= y4 || y == 4 * H && x >= H && x <= 2 * H;



            if (firstRectangle || secondRectangle || commonSide)
            {
                Console.WriteLine("inside");
            }

            else if (sidesfirst && !commonSide || sidesSecond && !commonSide)
            {
                Console.WriteLine("border");
            }
            else if (!firstRectangle || !secondRectangle)
            {
                Console.WriteLine("outside");
            }
        }
    }
}
