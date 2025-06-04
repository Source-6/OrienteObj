using DemoNamespace.Inventaire;

namespace DemoNamespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item objetInventaire = new Item();
            objetInventaire.nom = "pépite d'or";
            objetInventaire.value = 5000;


            Console.WriteLine($"j'ai une {objetInventaire.nom} de {objetInventaire.value} pièces d'or");
        }
    }
}