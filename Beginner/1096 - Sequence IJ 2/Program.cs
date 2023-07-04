using System;

namespace Beecrowd1096
{
    class Program
    {
        static void Main(string[] args)
        {

            int i=1, j=7;

            for(int contador = i; contador <= 9; contador+=2)
            {
                for(int cont = j; cont >= 5; cont--)
                {
                    Console.WriteLine($"I={contador} J={cont}");
                }
                j=7;
            }

        }
    }   
}