using Proprietes.Models;

namespace Proprietes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne();
            p1.Nom = "van der meirsch";
            p1.Prenom = "manon";
            p1.DateNaissance = new DateOnly(2000, 08, 22);

            Console.WriteLine($"bonjour {p1.Prenom} {p1.Nom}");
            Console.WriteLine($"agée de {p1.Age} ans");
        }
    }
}
