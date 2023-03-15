using System;
using System.Globalization;

namespace Beecrowd1065
{
    class Program
    {
        static void Main(string[] args)
        {

            int contador = 0, totalPares = 0, totalImpares = 0, totalPositivos = 0, totalNegativos = 0, numero; 

            while(contador < 5)
            {
                numero = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(numero % 2 == 0)
                {
                    totalPares += 1;
                }
                else
                {
                    totalImpares += 1;
                }

                if(numero > 0)
                {
                    totalPositivos += 1;
                }
                else if(numero < 0)
                {
                    totalNegativos += 1;
                }

                contador++;
            }

            Console.WriteLine($"{totalPares} valor(es) par(es)");
            Console.WriteLine($"{totalImpares} valor(es) impar(es)");
            Console.WriteLine($"{totalPositivos} valor(es) positivo(s)");
            Console.WriteLine($"{totalNegativos} valor(es) negativo(s)");
            Console.Read();

        }
    }
}