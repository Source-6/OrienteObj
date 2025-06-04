using Encapsulation.Models;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login monLogin = new Login();

            monLogin.email = "source@source.be";
            monLogin.ChangePassword("poppy\r");


            Console.WriteLine("introduire un email : ");
            string email = Console.ReadLine();

            Console.WriteLine("introduire mot de passe : ");
            ConsoleKeyInfo keyInfo;
            string password = "";

            do
            {
                keyInfo = Console.ReadKey(true);
                password += keyInfo.KeyChar;
                Console.Write(keyInfo.KeyChar);
            }
            while (keyInfo.Key != ConsoleKey.Enter);


            bool isConnected = monLogin.CheckUser(email,password);

            if (isConnected)
            {
                Console.WriteLine("oui");
            }
            else
            {
                Console.WriteLine("non");
            }
        }
    }
}
