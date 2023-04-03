using System;
using System.Collections.Generic;

namespace Beecrowd1018
{
    class Program
    {
        static void Main(string[] args)
        {

            int valor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(valor);

            int[] cedulas = new int[] {100, 50, 20, 10, 5, 2, 1}; 

            foreach (int nota in cedulas) 
            {
                int quantidadeNotas = valor / nota; 

                Console.WriteLine($"{quantidadeNotas} nota(s) de R$ {nota},00"); 
                valor = valor % nota; 
            }
        }
    }
}
