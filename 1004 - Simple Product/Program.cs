using System;

namespace Beecrowd1004
{
    class Program
    {
        static void Main (string[] args){

            int valor1 = Convert.ToInt32(Console.ReadLine());
            int valor2 = Convert.ToInt32(Console.ReadLine());
            int produto = valor1 * valor2;

            Console.WriteLine($"PROD = {produto}");

        }
    }
}