using System;

namespace arrayexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma alustaa kokonaislukutaulukon (10 alkiota), johon arvotaan lukuja 0... 100");
            int[] numbers = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(100);
                Console.WriteLine(numbers[i]);

            }
            Console.WriteLine("Ohjelman suoritus on päättynyt");

            

            


        }
    }
}
