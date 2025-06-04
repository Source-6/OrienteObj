﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proprietes.Models
{
    internal class Personne
    {
        private string _nom;
        public string Nom
        {
            get {
                return _nom.Substring(0, 1).ToUpper() + _nom.Substring(1).ToLower();
            }

            set {
                value = value.Trim();
                if(value.Length >= 2)
                {
                    _nom = value;
                }
            }
        }
        
        
        //private string _prenom;
        //public string Prenom
        //{
        //    get
        //    {
        //        return _prenom;
        //    }
        //    set
        //    {
        //        _prenom = value;
        //    }
        //}

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


    }
}
