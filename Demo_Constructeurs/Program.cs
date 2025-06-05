using Demo_Constructeurs.Models;

namespace Demo_Constructeurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonneNew quelconque = new PersonneNew();
            Console.WriteLine(quelconque.Prenom + quelconque.Nom);

            PersonneNew otherPerson = new PersonneNew("Chute");
            Console.WriteLine(otherPerson.Prenom + otherPerson.Nom);
        }
    }
}
