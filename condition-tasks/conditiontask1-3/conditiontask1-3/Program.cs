using System;

namespace conditiontask1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko luku positiivinen vai negatiivinen sekä onko luku pariton vai parillinen.");
            int number = 0;
            string posOrNeg = "";
            string evenOrOdd = "";

            Console.Write("Syötä luku: ");
            string userInput = Console.ReadLine();
            bool ifnumber = int.TryParse(userInput, out number);

            if (ifnumber)
            {
                if (number % 2 == 0)
                    evenOrOdd = "parillinen";
                else
                    evenOrOdd = "pariton";

                if (number == 0)
                    posOrNeg = "nolla";
                else if (number > 0)
                    posOrNeg = "positiivinen";
                else
                    posOrNeg = "negatiivinen";
            }
            else
                Console.WriteLine("Syöte ei ole luku.");

            Console.WriteLine($"Syöttämäsi luku {number} on {posOrNeg} ja {evenOrOdd}.");
        }
    }
}