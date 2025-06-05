using ExoJustePrix.Models;

namespace ExoJustePrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            do
            {
                Console.WriteLine("Choisir une difficulté : facile, moyen, difficile");
                JustePrix.Difficulty = Console.ReadLine();
                Console.WriteLine(JustePrix.Difficulty);

            } while (JustePrix.Difficulty is not "facile" and not "moyen" and not "difficile");


            int justePrix = JustePrix.SetDifficulty(JustePrix.Difficulty, JustePrix.NumJustePrix);
            Console.WriteLine($"Le juste prix est : {justePrix}");
            Console.WriteLine("Introduire une proposition : ");
            int.TryParse(Console.ReadLine(), out int userGuess);


            JustePrix.Verification(userGuess,justePrix);

        }
    }
}
