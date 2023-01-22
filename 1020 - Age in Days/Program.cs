using System;

namespace Beecrowd1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano, mes;
            int dias = Convert.ToInt32(Console.ReadLine());

            ano = dias / 365;
            Console.WriteLine($"{ano} ano(s)");
            dias = dias % 365;

            mes = dias / 30;
            Console.WriteLine($"{mes} mes(es)");
            dias = dias % 30;

            Console.WriteLine($"{dias} dia(s)");

        }
    }
}
