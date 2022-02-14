using System;

namespace SomaParesConsecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            while ((x = int.Parse(Console.ReadLine())) != 0)
            {
                int soma = 0;

                if (x % 2 != 0)
                {
                    x++;
                }

                for (int i = 0; i < 5; i++)
                {
                    soma += x + (i * 2);
                }
                Console.WriteLine($"{soma}");
            }

        }
    }
}
