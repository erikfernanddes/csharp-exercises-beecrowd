using System;

namespace Beecrowd1006
{
    class Program
    {
        static void Main(string[] args){

            int peso1 = 2;
            int peso2 = 3;
            int peso3 = 5;
            double nota1 = Convert.ToDouble(Console.ReadLine());
            double nota2 = Convert.ToDouble(Console.ReadLine());
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / 10;

            Console.WriteLine($"MEDIA = {media:F1}");
        }
    }
}