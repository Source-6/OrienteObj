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
        private static int _valeurMin;
        public static int ValeurMin
        {
            get
            {
                return _valeurMin;
            }
            set{
                if (value <= 0)
                {
                    _valeurMin = 1;
                }
                else if (value >= _valeurMax && _valeurMax != 0)
                {
                    _valeurMin = _valeurMax -1;
                }
                else
                {
                    _valeurMin = value;
                }
            }

        }



        private static int _valeurMax;
        public static int ValeurMax
        {
            get
            {
                return _valeurMax;
            }
            set
            {
                if (value <= 1)
                {
                    _valeurMax = 2;
                }
                else if (value <= _valeurMin)
                {
                    _valeurMax = _valeurMin +1;
                }
                else
                {
                    _valeurMax = value;
                }
            }
        }



        public static Random rng = new Random();

        public static int[] Lancer(int nbDes)
        {
            int[] dices = new int[nbDes];
            for (int i = 0; i < nbDes; i++)
            {
                dices[i] = rng.Next(ValeurMin, ValeurMax +1);
                Console.WriteLine(dices[i]);
            }
                Console.WriteLine($"valeur min : {ValeurMin}, valeur max : {ValeurMax}");
            return dices;
        }
    }
}

