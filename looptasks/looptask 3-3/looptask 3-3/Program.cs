using System;

namespace looptask_3_3
{
    class program
    {
        static void Main(string[] args)
        {

            int oddSum = 0;
            int evenSum = 0;

            Console.WriteLine("Ohjelma laskee N:n parittomien ja parillisten lukujen summan.");
            Console.Write("Syötä luku:");
            string userInput = Console.ReadLine();
            bool isNumber = int.TryParse(userInput, out int number);

            if (isNumber && number >= 1)
            {
                for (int i = 1; i <= number; i++)
                {
                    if (i % 2 == 0)
                        evenSum = evenSum + i;
                    else
                        oddSum = oddSum + i;

                }
                Console.WriteLine($"Parittomien summa = {oddSum}, Parillisten summa = {evenSum}");
            }
            else
                Console.WriteLine("Syöte ei kelpaa");
        }
    }
}

            
        
    
    