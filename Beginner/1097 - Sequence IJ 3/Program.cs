using System;

namespace Beecrowd1097
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1, j = 7;

            for(int contador = i; contador <=9; contador +=2)
            {
                int j2 = j;

                for(int cont = 0; cont <= 2; cont++)
                {
                    Console.WriteLine($"I={contador} J={j2}");
                    j2--;
                }
                j+=2;
            }

        }
    }
}