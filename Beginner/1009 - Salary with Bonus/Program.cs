using System;

namespace Beecrowd1009
{
    class Program
    {
        static void Main(string[] args){


        string nome = Console.ReadLine();
        double salario = Convert.ToDouble(Console.ReadLine());
        double totalVendas = Convert.ToDouble(Console.ReadLine());

        double novoSalario = salario + totalVendas * 15 / 100 ; 

        Console.WriteLine($"TOTAL = R$ {novoSalario:F2}");

        }
    }
}