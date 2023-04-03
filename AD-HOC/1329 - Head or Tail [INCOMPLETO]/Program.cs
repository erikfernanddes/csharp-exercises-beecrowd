using System;

namespace Beecrowd1329
{
    class Program
    {
        static void Main(string[] args)
        {

            /*                                                                  CARA OU COROA
            John e Mary são amigos desde a escola maternal. Desde então, eles compartilham uma rotina divertida: toda vez que se encontram, jogam Head ou Tail com uma moeda, e quem vencer tem o privilégio de decidir o que vai jogar durante o dia. Maria sempre escolhe Cabeça, e João sempre escolhe Cauda.

            Hoje em dia eles estão na faculdade, mas continuam sendo realmente bons amigos. Sempre que se encontram, ainda jogam Head and Tail, e o vencedor decide qual filme assistir ou qual restaurante jantar juntos, e assim por diante.

            Ontem, Mary confidenciou a John que ela estava mantendo um registro dos resultados de todas as peças desde que começaram, na escola maternal. Foi uma surpresa para John! Mas como John estuda Ciência da Computação, ele decidiu que era uma boa oportunidade para mostrar a Mary suas habilidades em programação, escrevendo um programa para determinar o número de vezes que cada um deles venceu o jogo ao longo dos anos. */

            
            
            while(true)
            {        
                string[] jogadas = Console.ReadLine().Split(' ');
                int A = Convert.ToInt32(jogadas[0]);
                int B = Convert.ToInt32(jogadas[1]);
                int C = Convert.ToInt32(jogadas[2]);

                if(A + B + C == 1)
                {
                    if(A == 1) {Console.WriteLine("A");}
                    if(B == 1) {Console.WriteLine("B");}
                    if(C == 1) {Console.WriteLine("C");}
                }
                else if(A + B + C == 2)
                {
                    if(A == 0) {Console.WriteLine("A");}
                    if(B == 0) {Console.WriteLine("B");}
                    if(C == 0) {Console.WriteLine("C");}
                }
                else
                {
                    Console.WriteLine(("*"));
                }


            }

            

            
        }
    }
}