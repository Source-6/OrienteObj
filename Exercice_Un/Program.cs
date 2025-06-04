using System.Runtime.InteropServices;
using Exercice_Un.Enums;
using Exercice_Un.Models;

namespace Exercice_Un
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" choisir un pion : ");
            string[] pionNames = Enum.GetNames<Pions>();

            foreach (string pionName in pionNames)
            {
                Console.WriteLine($"\t - {pionName}");
            }

            Console.WriteLine(" votre choix : ");
            string userInput = Console.ReadLine();
            Pions choice = Enum.Parse<Pions>(userInput);



            Dices.Lancer(2);
        }
    }
}
