using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice_Un.Enums;

namespace Exercice_Un.Models
{
    internal class Joueur
    {
        private string _nom;
        public string Nom { get; set; }

        private Pions _pions;
        public Pions Pion { get; set; }


        private int _position = 0;
        public int Position
        {
            get
            {
                return _position;
            }
        }

        private int _solde;
        public int Solde
        {
            get
            {
                return _solde;
            }
        }


        public bool Avancer()
        {
            Dices.ValeurMin = 1;
            Dices.ValeurMax = 6;

            int[] resultDices = Dices.Lancer(2);
            _position += resultDices[0] + resultDices[1];
            return resultDices[0]==resultDices[1];

        }


    }
}

