using System;

namespace array_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hinnasto");
            decimal[] productPrice = new decimal[] { 7.96m, 72.0m, 99.90m };
            int[] productAmount = new int[] { 1, 2, 3 };
            decimal[] productTotalprice = new decimal[3];
            for (int i = 0; i < productTotalprice.Length;++i)
            {
                productTotalprice[i] = productAmount[i] * productPrice[i];
                Console.WriteLine($"Tuote {i + 1}.{productTotalprice[i]:c}");
            }
        }
    }
}
