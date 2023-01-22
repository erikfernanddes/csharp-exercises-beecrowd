using System;
using System.Collections.Generic;

namespace Beecrowd1013
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] valores = new string[3];
            int a, b, c, maiorAB, maiorABC;
            
            valores = Console.ReadLine().Split(' ');
            a = Convert.ToInt32(valores[0]);
            b = Convert.ToInt32(valores[1]);
            c = Convert.ToInt32(valores[2]);

            maiorAB = (a + b + Math.Abs(a-b))/2;
            maiorABC = (maiorAB + c + Math.Abs(maiorAB - c))/2;

            Console.WriteLine($"{maiorABC} eh o maior");

        }
    }    
}