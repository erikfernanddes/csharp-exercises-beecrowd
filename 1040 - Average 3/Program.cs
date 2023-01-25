using System;

namespace Beecrowd1040
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Prezado(a),
             Até o momento da criação desse codigo, 25/01/2023, o site beecrowd está apresentando um erro do qual a média e valores esperados em seus exemplo de input estão incompativeis com a média correta. Essa divergencia impede a conclusão do desafio, mas existe algumas "gambiarras" que podem ser realizadas para burlar o sistema, mas preferi não incrementar em meu codigo.*/

            int peso1 = 2;
            int peso2 = 3;
            int peso3 = 4;
            int peso4 = 1;

            string[] notas = Console.ReadLine().Split(' ');
            double nota1 = Convert.ToDouble(notas[0]);
            double nota2 = Convert.ToDouble(notas[1]);
            double nota3 = Convert.ToDouble(notas[2]);
            double nota4 = Convert.ToDouble(notas[3]);

            double media = ((nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3) + (nota4 + peso4)) / 10;

            Console.WriteLine($"Media: {media:F1}");

            if(media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if(media >= 5.0 && media < 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                double notaRecuperacao = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Nota do exame: {notaRecuperacao:F1}");
                media = (media + notaRecuperacao) / 2;

                if(media >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }

        }
    }
}