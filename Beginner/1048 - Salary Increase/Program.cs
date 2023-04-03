using System;

namespace Beecrowd1048
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario = Convert.ToDouble(Console.ReadLine());
            double reajusteGanho = 0, novoSalario = 0, porcentagem = 0;

            if(salario >= 0 && salario <= 400)
            {       
                reajusteGanho = salario * 15 / 100;
                novoSalario = salario + reajusteGanho;
                porcentagem = 15;
            }
            else if(salario > 400 && salario <= 800)
            {
                reajusteGanho = salario * 12 / 100;
                novoSalario = salario + reajusteGanho;
                porcentagem = 12;
            }
            else if(salario > 800 && salario <= 1200)
            {
                reajusteGanho = salario * 10 / 100;
                novoSalario = salario + reajusteGanho;
                porcentagem = 10;
            }
            else if(salario > 1200 && salario <= 2000)
            {
                reajusteGanho = salario * 7 / 100;
                novoSalario = salario + reajusteGanho;
                porcentagem = 7;
            }
            else if (salario > 2000)
            {
                reajusteGanho = salario * 4 / 100;
                novoSalario = salario + (salario * 4 / 100 );
                porcentagem = 4;
            }

            Console.WriteLine($"Novo salario: {novoSalario:F2}");
            Console.WriteLine($"Reajuste ganho: {reajusteGanho:F2}");
            Console.WriteLine($"Em percentual: {porcentagem} %");

            Console.Read();

        }
    }
}