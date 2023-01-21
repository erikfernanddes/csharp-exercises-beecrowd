using System;

namespace Beecrowd1011
{
    class Program
    {
        static void Main(string[] args){

            double pi = 3.14159;
            double A = Convert.ToDouble(Console.ReadLine());
            double vol = (4/3.0) * pi * Math.Pow(A, 3) ; // IMPORTANTE COLOCAR O NUMERO DA DIVISÃO DIVIDIDO POR UM NUMERO DECIMAL, CASO CONTRARIO, O PROGRAMA DIVIDE E TRUCA EXIBINDO APENAS A PARTE INTEIRA, OCASIONANDO NO ERRO DA EXIBIÇÃO CORRETA DO VALOR.

            Console.WriteLine($"VOLUME = {vol:F3}");


        }
    }
}