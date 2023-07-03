using System;

namespace Beecrowd1080
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region Highest and Position
            /*                       Highest and Position
            Read 100 integer numbers. Print the highest read value and the input position.

            Input
            The input file contains 100 distinct positive integer numbers.

            Output
            Print the highest number read and the input position of this value
            */
            #endregion

            int contador = 1, maior = 0, posicao = 0, numero;

            while(contador <= 100)
            { 
                numero = Convert.ToInt32(Console.ReadLine());
                
                if(numero > maior)
                {
                    maior = numero;
                    posicao = contador;
                }
                contador++;
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);

        }
    }
}