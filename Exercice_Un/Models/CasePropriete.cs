using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice_Un.Enums;

namespace Exercice_Un.Models
{
    internal class CasePropriete
    {
        private string _name;
        public string Name { get; private set; }



        private Couleurs _color;
        public Couleurs Color { get; private set; }
        

        private int _price;
        public int Price { get; private set; }

        private bool _isMortgaged;
        public bool IsMortgaged { get; private set; }

        private Joueur _landlord;
        public Joueur Landlord { get; private set; }


        public CasePropriete(string name, Couleurs color, int price)
        {
            Name = name;
            Color = color;
            Price = price;
            IsMortgaged = false;
            Landlord = null;

        }



        public void Acheter(Joueur acheteur)
        {
            if (acheteur.Solde >= Price)
            {
                _isMortgaged = true;
                Landlord = acheteur;
            }
        }


    }
}
