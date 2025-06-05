using System.Runtime.InteropServices;
using Exercice_Un.Enums;
using Exercice_Un.Models;

namespace Exercice_Un
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Indiquez votre nom : ");
            string userName = Console.ReadLine();



            Console.WriteLine("choisir un pion : ");
            string[] pionNames = Enum.GetNames<Pions>();
            //Pions[] pions = Enum.GetValues<Pions>();

            foreach (string pionName in pionNames)
            {
                Console.WriteLine($"\t - {pionName}");
            }

            Console.WriteLine("votre choix : ");

            string userInput = Console.ReadLine();
            Pions choice = Enum.Parse<Pions>(userInput);


            Joueur j1 = new Joueur()
            {
                Nom = userName,
                Pion = choice,
            };

            Console.WriteLine($"Joueur {j1.Nom} avec le pion {j1.Pion} se trouve à la case {j1.Position}");


            bool isDouble = j1.Avancer();
            if (isDouble)
            {
                Console.WriteLine($"c'est un double");
            }
            Console.WriteLine($"Joueur {j1.Nom} avec le pion {j1.Pion} se trouve à la case {j1.Position}");



        }
    }
}
