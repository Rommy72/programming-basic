using System;

namespace loop_task_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("simuloi kolikon heittoa");
            Console.Write("kuinka monta kertaa kolikkoa heitetään");
            int counter = int.Parse(Console.ReadLine());
            int heads = 0;
            int tails = 0;
            Random rnd = new Random();

            for (int i = 0; i < counter; i++)
            {
                int rndNumber = rnd.Next(2);
                if (rndNumber == 0)
                    tails++;
                else
                    heads++;

            }
            Console.WriteLine($"rahaa on heitetty{counter} kertaa.");
            Console.WriteLine($"klaavoja tuli{tails} ja kruunuja {heads}.");
            {

            }
        }
    }
}
