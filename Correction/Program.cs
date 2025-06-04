﻿using Correction.Enums;
using Correction.Models;

namespace Correction
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
                nom = userName,
                pion = choice,
            };

            Console.WriteLine($"Joueur {j1.nom} avec le pion {j1.pion} se trouve à la case {j1.position}");


            bool isDouble = j1.Avancer();
            if (isDouble)
            {
                Console.WriteLine($"c'est un double");
            }
            Console.WriteLine($"Joueur {j1.nom} avec le pion {j1.pion} se trouve à la case {j1.position}");


        }
    }
}
