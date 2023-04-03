using System;

namespace Beecrowd1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int horarioInicial, horarioFinal, duracao;
            
            string[] horario = Console.ReadLine().Split(' ');
            horarioInicial = Convert.ToInt32(horario[0]);
            horarioFinal = Convert.ToInt32(horario[1]);

            if(horarioInicial >= horarioFinal)
            {
                duracao = (horarioFinal + 24) - horarioInicial;
            }
            else
            {
                duracao = horarioFinal - horarioInicial;
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
            Console.Read();
        }
    }
}
