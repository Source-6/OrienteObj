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

        public string Nom { get; set; }
        public Pions Pion { get; set; }


        private int _position = 0;
        public int Position { get; private set; }
        

        private int _solde;
        public int Solde { get; private set; }

        private List<CasePropriete> _proprietes;
        public List<CasePropriete> Proprietes { get; private set; }


        public Joueur (string name, Pions pion)
        {
            Solde = 1500;
            Position = 0;
            Proprietes = new List<CasePropriete>();

        }


        public bool Avancer()
        {
            Dices.ValeurMin = 1;
            Dices.ValeurMax = 6;

            int[] resultDices = Dices.Lancer(2);
            _position += resultDices[0] + resultDices[1];
            return resultDices[0]==resultDices[1];

        }


        public void EtrePayer(int montant)
        {
            //permet d'ajouter montant au solde du joueur
        }

        public void Payer(int montant)
        {
            //permet de diminuer solde du montant (solde peut pas <0)
        }

        public void AjouterPropriete(CasePropriete propriete)
        {
            //ajouter la propriete dans liste Propriete seulement si celle-ci a comme proprietaire le joueur 
        }


    }
}

