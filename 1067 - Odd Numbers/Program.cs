using System;
using System.Globalization;

namespace Beecrowd1067
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numero = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);

            for(int contador = 0; contador <= numero; contador++)
            {              
                if(contador % 2 != 0)
                {
                    Console.WriteLine(contador);
                }
            }

        }
    }
}