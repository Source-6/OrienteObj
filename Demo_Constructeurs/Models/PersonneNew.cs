using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Constructeurs.Models
{
    internal class PersonneNew
    {
        private string _nom;
        public string Nom
        {
            get
            {
                return _nom.Substring(0, 1).ToUpper() + _nom.Substring(1).ToLower();
            }

            set
            {
                value = value.Trim();
                if (value.Length >= 2)
                {
                    _nom = value;
                }
            }
        }


        public string Prenom { get; set; }




        public string NomComplet
        {
            get
            {
                return $"{Prenom} {Nom}";
            }
        }



        private DateOnly _dateNaissance;
        public DateOnly DateNaissance
        {
            set
            {
                _dateNaissance = value;
            }
        }

        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - _dateNaissance.Year;
                if (DateTime.Now.Month < _dateNaissance.Month) age--;
                return age;
            }
        }

        public PersonneNew()    //ça c'est le constructeur (seule méthode avec m^m nom que la classe /!\)
        {
            Nom = "Sol";
            Prenom = "Para";
            DateNaissance = new DateOnly(1000,02,03);

        }

        public PersonneNew(string paramNom )
        {
            Nom = paramNom;
            Prenom = "Para";
            DateNaissance = new DateOnly(1000, 02, 03);

        }

        public PersonneNew(string paramNom, string paramPrenom)
        {
            Nom = paramNom;
            Prenom = paramPrenom;
        }

        public PersonneNew(string paramNom, string paramPrenom, DateOnly paramNaiss)
        {
            Nom = paramNom;
            Prenom = paramPrenom;
            DateNaissance = paramNaiss;
        }

    }
}
