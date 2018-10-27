using System;

namespace iftask_2_1
{ 

    class Program
    {
        static void Main(string[] args)
        {   // Ohjelma määrittelee lipun Hinnan alennuksineen
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double ticketPrice = 16.00;
            double discount = 0;

            Console.WriteLine($"Lipun hinta ilman alennuksia  {ticketPrice}.");
            Console.Write("Anna ikäsi: ");
            string userInput = Console.ReadLine();
            int age = int.Parse(userInput);

            if (age < 7)
                discount = 1;
            else if (age >= 65)
                discount = 0.5;
            else if (age >= 7 && age <= 15)
                discount = 0.5;
            else
            {
                Console.Write("1. Varusmies\n2. Opiskelija\n3. Opiskelija sekä MTK jäsen\n4. MTK jäsen\n5. Ei mikään\nValitse sopiva kategoria (1-5): ");
                string userInput1 = Console.ReadLine();
                int userChoice = int.Parse(userInput1);

                if (userChoice == 1)
                    discount = 0.5;
                else if (userChoice == 2)
                    discount = 0.45;
                else if (userChoice == 3)
                    discount = 0.60;
                else if (userChoice == 4)
                    discount = 0.15;
                else if (userChoice == 5)
                    discount = 0;
            }
            Console.WriteLine($"Uusi lipunhinta on {ticketPrice - ticketPrice * discount}€.");
        }
    }
}
