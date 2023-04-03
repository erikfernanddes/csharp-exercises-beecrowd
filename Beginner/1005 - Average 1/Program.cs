using System;

namespace Ex005
{
    class Program
    {
        static void Main (string[] args){
            double peso1 = 3.5;
            double peso2 = 7.5;
            double nota1 = Convert.ToDouble(Console.ReadLine());
            double nota2 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 * peso1 + nota2 * peso2) / 11; 

            Console.WriteLine($"MEDIA = {media:F5}");
        }
    }
}