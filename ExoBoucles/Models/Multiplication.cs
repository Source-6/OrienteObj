using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBoucles.Models
{
    internal class Multiplication
    {
        internal static void MultiParDeux()
        {
            int num;
            int multi = 2;

            for(num = 1; num <= 10; num++)
            {
                Console.WriteLine(num*multi);
            }
        }

        internal static void MultiDix()
        {
            int num;
            int multi;

            for(num = 1;num <= 9; num++)
            {
                Console.WriteLine($"Table de : {num}");
                for(multi = 1;multi <= 10; multi++)
                {
                    Console.WriteLine(num*multi);
                }
            }

        }
    }
}
