using System;
using System.Collections.Generic;

namespace Beecrowd1042
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> listaNumeros = new List<int>();
            List<int> listaNumerosOrdemCrescente = new List<int>();

            string[] valoresDigitados = Console.ReadLine().Split(' ');
            int valor1 = Convert.ToInt32(valoresDigitados[0]);
            int valor2 = Convert.ToInt32(valoresDigitados[1]);
            int valor3 = Convert.ToInt32(valoresDigitados[2]);
            
            listaNumeros.Add(valor1);
            listaNumeros.Add(valor2);
            listaNumeros.Add(valor3);
            listaNumerosOrdemCrescente.AddRange(listaNumeros);
            listaNumerosOrdemCrescente.Sort();

            foreach (int numero in listaNumerosOrdemCrescente)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine();
            foreach (int numero in listaNumeros)
            {
                Console.WriteLine(numero);
            }
            
        }
    }
}
