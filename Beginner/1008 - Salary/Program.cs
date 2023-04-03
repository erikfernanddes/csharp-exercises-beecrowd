using System;

namespace Beecrowd1008
{
    class Program
    {
        static void Main(string[] args){

            int numeroIdentificacao = Convert.ToInt32(Console.ReadLine());
            int horasTrabalhadas = Convert.ToInt32(Console.ReadLine());
            decimal valorHora = Convert.ToDecimal(Console.ReadLine());
            decimal salario = horasTrabalhadas * valorHora;

            Console.WriteLine($"NUMBER = {numeroIdentificacao}");
            Console.WriteLine($"SALARY = U$ {salario}");

        }
    }
}