using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Sunglasses
{
    class Program
    {
        static void Main(string[] args)

        {

            int n = int.Parse(Console.ReadLine());

            // PRINT THE TOP PART

            Console.Write(new string('*', 2 * n));
             Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));

            // print mid part of sunglasses

            for (int row = 2; row <= n - 1; row++)
            {
                // Left side

                Console.Write("*");
                Console.Write(new string('/', (2 * n) - 2));
                Console.Write("*");


                // ------element
                if ((row-2) == (n - 1 ) / 2 - 1)
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }



              // right side
                Console.Write("*");
                Console.Write(new string('/', (2 * n) - 2));
                Console.WriteLine("*");


               // print the bottom part

                Console.Write(new string('*', 2 * n));
                Console.Write(new string(' ', n));
                Console.WriteLine(new string('*', 2 * n));



            }
        }
    }
}
