using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Static.Models
{
    internal class Formation
    {
        public static string centre;
        public string nom;

        public List<string> eleves;

        public void Decrire()
        {
            ConsoleRainbow.WriteLine($"La formation est {nom}, et ses élèves : ");
            foreach(string eleve in eleves)
            {
                ConsoleRainbow.WriteLine($"\t- {eleve}");
            }
        }

        public static void Description()
        {
            ConsoleRainbow.WriteLine($"Regroupe l'ensemble des formations de {centre}");
        }


    }
}
