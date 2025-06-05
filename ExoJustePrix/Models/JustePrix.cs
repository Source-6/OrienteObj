using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoJustePrix.Models
{
    internal static class JustePrix
    {
        private static string _difficulty;
        public static string Difficulty { get; set; }

        private static int _numJustePrix;
        public static int NumJustePrix { get; set; }


        public static int SetDifficulty(string difficulty,int numJustePrix)
        {
            Random rand = new Random();
            int maxVal = 0;
            
            switch (difficulty)
            {
                case "facile":
                    maxVal = 10;
                    break;
                case "moyen":
                    maxVal = 100;
                    break;
                case "difficile":
                    maxVal = 1000;
                    break;

            }

            return numJustePrix = rand.Next(1, maxVal);
        }

        public static void Verification(int userGuess, int justePrix)
        {
            int tentatives = 1;

            while(tentatives < 10 && justePrix != userGuess)
            {
                if (justePrix > userGuess)
                {
                    Console.WriteLine("c'est plus !");
                    
                }
                else
                {
                    Console.WriteLine("c'est moins");
                }
                Console.WriteLine("Introduire une proposition : ");
                int.TryParse(Console.ReadLine(), out userGuess);
                tentatives++;
            }
            if (tentatives == 10)
            {
                Console.WriteLine($"perdu le juste prix était {justePrix}");
            }
            else
            {
                Console.WriteLine("c'est juste ! ");
                if (tentatives > 1)
                {
                    Console.WriteLine($"Vous avez réussi en {tentatives} tentatives ");
                }
                else
                {
                    Console.WriteLine($"Vous avez réussi en {tentatives} tentative ");

                }
            }
        }
    }
}
