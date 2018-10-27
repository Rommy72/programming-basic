using System;

namespace looptask_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee annetun luvun summan");
            int number = 0;
            int i = 0;
            int sum = 0;
            do
            {
                Console.Write("syötä luku: ");
                number = int.Parse(Console.ReadLine());

                if (number <= 0)
                    Console.WriteLine("Virheellinen syöte!");



            } while (number <= 0);

            while (i <= number)
            {
                sum = sum + i;
                i = i + 1;
            }
            Console.WriteLine($"Luvun{number}! = {sum}");

        }
    }
}
