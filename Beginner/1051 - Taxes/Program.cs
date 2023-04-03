using System;

namespace Beecrowd1051
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario = Convert.ToDouble(Console.ReadLine());
            double taxa = 0.00;
            bool isento = salario < 2000.00;

            if(salario > 2000.00 && salario <= 3000.00)
            {
                taxa =  (salario - 2000.00) * 8 / 100;
            } 
            else if(salario > 3000.00 && salario < 4500.00)
            {
                taxa = (salario - 3000.00) * 18 / 100 + 80.00; //Imposto de 8% sobre 1000;
            }
            else
            {
                taxa = ((salario - 4500.0) * 28 / 100) + (1500.0 * 18 / 100) + (1000.0 * 8 / 100);
            }

            Console.WriteLine((isento ? "Isento" : $"R$ {taxa:F2}"));
        
        }
    }
}
