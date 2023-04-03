using System;
using System.Collections.Generic;

namespace Beecrowd1045
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<double> ladosDoTriangulo = new List<double>();

            string[] valores = Console.ReadLine().Split(' ');
            ladosDoTriangulo.Add(Convert.ToDouble(valores[0]));
            ladosDoTriangulo.Add(Convert.ToDouble(valores[1]));
            ladosDoTriangulo.Add(Convert.ToDouble(valores[2]));

            ladosDoTriangulo.Sort();
            ladosDoTriangulo.Reverse();

            double ladoA = ladosDoTriangulo[0];
            double ladoB = ladosDoTriangulo[1];
            double ladoC = ladosDoTriangulo[2];

            if(ladoA >= ladoB + ladoC)
            {
                System.Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if(Math.Pow(ladoA, 2) == (Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2)))
                {
                    System.Console.WriteLine("TRIANGULO RETANGULO");
                }
                if(Math.Pow(ladoA, 2) > (Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2)))
                {
                    System.Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                if(Math.Pow(ladoA, 2) < (Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2)))
                {
                    System.Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                if(ladoA == ladoB && ladoB == ladoC)
                {
                    System.Console.WriteLine("TRIANGULO EQUILATERO");
                }
                if(ladoA == ladoB && ladoC !=ladoA || ladoC == ladoA && ladoC != ladoB || ladoB == ladoC && ladoB != ladoA)
                {
                    System.Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }

        }
    }
}
