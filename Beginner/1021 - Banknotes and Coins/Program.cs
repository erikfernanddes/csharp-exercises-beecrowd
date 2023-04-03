using System;
using System.Globalization;
using System.Collections.Generic;

namespace beecrowd_1021
{
    class Program
    {
        static void Main(string[] args)
        {

            double dinheiro = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture); 

            List<double> cedula = new List<double>(){100, 50, 20, 10, 5, 2};
            List<double> centavos = new List<double>() {1, 0.50, 0.25, 0.10, 0.05, 0.01};

            Console.WriteLine("NOTAS:");
            foreach (double nota in cedula)
            {
                double quantidadeNotas = dinheiro / nota;
                Console.WriteLine($"{(int)quantidadeNotas} nota(s) de R$ {nota:F2}"); 
                dinheiro %= nota; 
            }

            dinheiro *= 100; //Para facilitar o calculo de centavos, multiplicamos o valor decimal por 100 para trabalharmos com o numero inteiro ao inves de decimal. Em relação visual, não irá alterar;

            Console.WriteLine("MOEDAS:");
            foreach (double moeda in centavos)
            {
                double moedaConvertida = moeda * 100; //Assim como a mutiplicação do valor flutuante por 100, precisamos tambem multiplicar o valor da moeda para termos um inteiro.
                double quantidadeMoeda = dinheiro / moedaConvertida;
                Console.WriteLine($"{(int)quantidadeMoeda} moeda(s) de R$ {moeda:F2}");
                dinheiro %= moedaConvertida;
            }

        }
    }
}
