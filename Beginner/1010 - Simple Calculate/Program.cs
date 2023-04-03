using System;

namespace Beecrowd1010
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] prod1 = Console.ReadLine().Split(' '); 

            int codigo = Convert.ToInt32(prod1[0]);
            int quantidade = Convert.ToInt32(prod1[1]);
            double valorUnitario = Convert.ToDouble(prod1[2]);

            string[] prod2 = Console.ReadLine().Split(' ');
            int codigo2 = Convert.ToInt32(prod2[0]);
            int quantidade2 = Convert.ToInt32(prod2[1]);
            double valorUnitario2 = Convert.ToDouble(prod2[2]);

            double total = quantidade * valorUnitario + quantidade2 * valorUnitario2 ;

            Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");
        }
    }
}