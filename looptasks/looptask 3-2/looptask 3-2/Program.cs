using System;

namespace looptask_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee luvun yhteen myös negatiivisilla numeroilla.");
            Console.Write("Syötä luku: ");      
            string userInput = Console.ReadLine();
            bool isNumber = int.TryParse(userInput, out int number);   
            int sum = 0;

            if (isNumber)      
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
                Console.WriteLine("syöte ei kelpaa");
        }
    }
}
