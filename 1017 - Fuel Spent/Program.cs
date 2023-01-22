using System;

namespace Beecrowd1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int horasPercorridas = Convert.ToInt32(Console.ReadLine());
            int kmPorHora = Convert.ToInt32(Console.ReadLine());
            double gasolinaConsumida = Convert.ToDouble(horasPercorridas) * kmPorHora / 12;
            
            Console.WriteLine(gasolinaConsumida.ToString("F3"));
        }
    }
}