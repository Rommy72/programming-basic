using System;

namespace looptask3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int i = 1;
            int evenSum = 0;
            int oddSum = 0;

            Console.WriteLine("Ohjema laskee parittomien ja parillisten summan");
            
                Console.Write("Syötä luku: ");
            number = int.Parse(Console.ReadLine());
            while (i <= number)
            {
                if (i % 2 == 0)
                {
                    evenSum += i; //evenSum = evenSum + i

                }
                else

                {
                    oddSum = oddSum + i;

                }
                i++;
            }
            Console.WriteLine($"Parillisten summa on {evenSum}");
            Console.WriteLine($"parittomien summa on {oddSum}");


        }
    }
}
