using System;

namespace Beecrowd1044
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] valores = Console.ReadLine().Split(' ');
            int primeiroValor = Convert.ToInt32(valores[0]);
            int segundoValor = Convert.ToInt32(valores[1]);

            if(primeiroValor % segundoValor == 0 || segundoValor % primeiroValor == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
    }
}
