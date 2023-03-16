// Faça um programa em C# que imprima todos os múltiplos de 3, entre 1 e 100.
// Para saber se um número é múltiplo de 3, você pode fazer if(numero % 3 == 0).

using System;

namespace Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 3; i < 100; i += 3)
            {
                Console.WriteLine(i);
            }

        }
    }
}
