using System;
using System.Globalization;

namespace Beecrowd1064
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1, totalPositivos = 0;
            double numero, somaPositivos = 0, media;

            while(contador <= 6)
            {
                numero = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if(numero > 0)
                {
                    totalPositivos += 1;
                    somaPositivos += numero;
                }
                contador++;
            }

            media = somaPositivos / totalPositivos;

            Console.WriteLine($"{totalPositivos} valores positivos");
            Console.WriteLine($"{media:F1}");
        }
    }
}