using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBoucles.Models
{
    internal class Lignes
    {
        internal static void Affichage()
        {
            Console.WriteLine("Entrez un nombre : ");
            int.TryParse(Console.ReadLine(), out int num);

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"*");
                }
                Console.WriteLine();
            }
        }
    }
}
