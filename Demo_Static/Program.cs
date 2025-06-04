using Demo_Static.Models;

namespace Demo_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Formation games = new Formation()
            {
                nom = "Games25",
                eleves = new List<string>(["Manon", "Begüm", "Estelle", "Gaëlle", "Lyst"])
            };
            Formation.centre = "Interface3";

            Formation wad = new Formation()
            {
                nom = "Wad25",
                eleves = new List<string>(["Laura", "Emilie", "Yulia", "Anaïs", "Siham", "Tran"])
            };

            games.Decrire();
            wad.Decrire();
            Formation.Description();

        }
    }
}
