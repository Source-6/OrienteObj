using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Un.Models
{
    internal static class Dices
    {
        static int valeurMin = 1;
        static int valeurMax = 6;
        static Random rnd = new Random();

        public static int[] Lancer(int nbDes)
        {
            int[] dices = new int[nbDes];
            for (int i = 0; i < nbDes; i++)
            {
                dices[i] = rnd.Next(valeurMin, valeurMax);
                Console.WriteLine(dices[i]);
            }
            return dices;
        }
    }
}

