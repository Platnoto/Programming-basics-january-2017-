using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // up part

            for (int row = 1; row <=n ; row++)
            {
                for (int col = 1; col <= n-row; col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");

                for (int col = 1; col < row; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            // Down part // цикълът брои отзад напред
            for (int row = n - 1; row >= 1; row--) //row = row - 1; row=-1;
            {
                for (int col = n-row; col >= 1; col--)
                {
                    Console.Write(" ");
                }
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        



        }
    }
}
