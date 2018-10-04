using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko annettu luku " +
                "positivinen " +
                "negatiivinen vai nolla ");
            Console.WriteLine("Syötä luku");
            string UserInput = Console.ReadLine();
            Console.WriteLine($"Syötit numeron {UserInput}");
            double number = double.Parse(UserInput);
            if (number == 0)
                Console.WriteLine($"Numero {number} on nolla!");
            else if(number<0)
                Console.WriteLine($"Numero {number} on negatiivinen!");
            else
                Console.WriteLine($"Numero {number} on positiivinen!");

        }
    }
}
