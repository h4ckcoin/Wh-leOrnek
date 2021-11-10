using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhıleOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            // (1 * 2 - 3 * 4 ) + ( 5 * 
            //int a = 1; // a1
            //int b = 2; // b1
            //int c = 3; // c1
            //int d = 4; // d1
            //int toplam = 0;


            //while (a <= 997)
            //{
            //    toplam += a * b - c * d;
            //    a += 4;
            //    b += 4;
            //    c += 4;
            //    d += 4;
            //}

            int toplam = 0;
            for (int a1 = 1; a1 <= 997; a1 += 4)
            {
                toplam += a1 * (a1 + 1) - (a1 + 2) * (a1 + 3);
            }

           

            Console.WriteLine("Toplam: " + toplam);
            Console.ReadLine();



        }
    }
}
