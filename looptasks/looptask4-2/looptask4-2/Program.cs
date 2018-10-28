using System;

namespace looptask4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma tulostaa 9 kertotaulun ");
            Console.WriteLine("aloita ohjelman suoritus painamalla jotain nappia ");
            Console.ReadLine();
            for (int i = 1; i <= 9; i++)
                for (int j = 1; j < 9; j++)
                    Console.WriteLine($"{i}x{j}={i * j}");


        }
    }
}
