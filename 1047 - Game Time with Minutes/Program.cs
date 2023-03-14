using System;

namespace Beecrowd1047
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tempoDeJogo = Console.ReadLine().Split(' ');
            int horaInicial = Convert.ToInt32(tempoDeJogo[0]);
            int minutoInicial = Convert.ToInt32(tempoDeJogo[1]);
            int horaFinal = Convert.ToInt32(tempoDeJogo[2]);
            int minutoFinal = Convert.ToInt32(tempoDeJogo[3]);

            int inicioEmMinutos = (horaInicial * 60) + minutoInicial;
            int finalEmMinutos = (horaFinal * 60) + minutoFinal;
            int duracaoPartida;

            if(inicioEmMinutos < finalEmMinutos)
            {
                duracaoPartida = finalEmMinutos - inicioEmMinutos;
            }
            else
            {
                duracaoPartida = (24 * 60 - inicioEmMinutos) + finalEmMinutos;
            }
            
            int duracaoHoras = duracaoPartida / 60;
            int duracaoMinutos = duracaoPartida % 60;

            Console.WriteLine($"O JOGO DUROU {duracaoHoras} HORA(S) E {duracaoMinutos} MINUTO(S)");

        }
    }
}