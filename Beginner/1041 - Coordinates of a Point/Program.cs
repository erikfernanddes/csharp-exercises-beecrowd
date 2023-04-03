using System;
using System.Globalization;

namespace Beecrowd1041
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] posicaoEixosXY = Console.ReadLine().Split(' ');
            double eixoX = Convert.ToDouble(posicaoEixosXY[0]);
            double eixoY = Convert.ToDouble(posicaoEixosXY[1]);

            if(eixoX == 0 & eixoY == 0)
            {
                Console.WriteLine("Origem");
            }
            else if(eixoX != 0 & eixoY == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if(eixoX == 0 & eixoY != 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if(eixoX > 0 && eixoY > 0)
            {
                Console.WriteLine("Q1");
            }
            else if(eixoX > 0 && eixoY < 0)
            {
                Console.WriteLine("Q4");
            }
            else if(eixoX < 0 && eixoY > 0)
            {
                Console.WriteLine("Q2");
            }
            else if(eixoX < 0 && eixoY < 0)
            {
                Console.WriteLine("Q3");
            }
            Console.Read();
        }
    }
}