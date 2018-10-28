using System;

namespace looptask3_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ohjelma laskee lukua yhteen myös negatiivisilla numeroilla.");
            Console.Write("Syötä luku: ");      
            string userInput = Console.ReadLine();
            bool ifNumber = int.TryParse(userInput, out int number);    
            int sum = 0;

            if (ifNumber)      
            {
                if (number > 0)        
                    for (int i = 0; i <= number; i++)
                        sum = sum + i;
                else                    
                    for (int i = 0; i >= number; i--)
                        sum = sum + i;
                Console.WriteLine($"Vastaus: {sum}");
            }
            else
                Console.WriteLine("Antamasi syöte ei kelpaa");
        }
    }
}

