using System;
using System.Globalization;

namespace Beecrowd1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1, totalPares = 0, numero;

            while(contador <= 5)
            {
                numero = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(numero % 2 == 0)
                {
                    totalPares += 1;
                }

                contador++;
            }

            Console.WriteLine($"{totalPares} valores pares");
        }
    }
}