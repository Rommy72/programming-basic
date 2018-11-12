using System;

namespace stringtask1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee käyttäjän syötteestä merkkien määrän.");
            string strCount = UserInput();

            Console.WriteLine($"Kirjoitit {strCount}.\n Siinä on {LengthOfString(ref strCount)} merkkiä.");

        }
        static string UserInput()
        {
            Console.Write("Syötä lause: ");
            string userInput = Console.ReadLine();
            return userInput;
        }

        static int LengthOfString(ref string a)
        {
            int length = a.Length;
            return length;
        }
    }
}