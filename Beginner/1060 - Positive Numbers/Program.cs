using System;
using System.Globalization;

namespace Beecrowd1060
{
    class Program
    {
        static void Main (string[] args)
        {

            int contador = 0, totalPositivos = 0;
            double numero;

            while(contador < 6)
            {
                numero = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(numero > 0)
                {
                    totalPositivos += 1;
                }

                contador++;
            }

            Console.WriteLine($"{totalPositivos} valores positivos");

        }
    }
}