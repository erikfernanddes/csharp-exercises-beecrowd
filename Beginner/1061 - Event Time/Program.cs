using System;
using System.Globalization;

namespace TempoDeUmEvento
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaInicio, horaInicio, minutoInicio, segundoInicio, diaFinal, horaFinal, minutoFinal, segundoFinal; //armazenamento
            int totalDias, totalHoras, totalMinutos, totalSegundos, horarioInicioEmSegundos, horarioFinalEmSegundos, duracao; //tratamento e conversões.

            // Lendo e armazenando os dados da HORARIO INICIAL 
            string[] data = Console.ReadLine().Split(' ');
            diaInicio = Convert.ToInt32(data[1]);

            string [] horario = Console.ReadLine().Split(' ');
            horaInicio = Convert.ToInt32(horario[0]);
            minutoInicio = Convert.ToInt32(horario[2]);
            segundoInicio = Convert.ToInt32(horario[4]);

            // Lendo e armazenando os dados da HORARIO FINAL
            data = Console.ReadLine().Split(' ');
            diaFinal = Convert.ToInt32(data[1]);

            horario = Console.ReadLine().Split(' ');
            horaFinal = Convert.ToInt32(horario[0]);
            minutoFinal = Convert.ToInt32(horario[2]);
            segundoFinal = Convert.ToInt32(horario[4]);

            // Convertendo todo o horario (dia, hora, minuto) em segundos.
            horarioInicioEmSegundos = (diaInicio * 24) * 3600 + horaInicio * 3600 + minutoInicio * 60 + segundoInicio;
            horarioFinalEmSegundos = (diaFinal * 24) * 3600 + horaFinal * 3600 + minutoFinal * 60 + segundoFinal;

            // Calculando a duração tirando a diferença final e inicial e convertendo os segundos dessa diferença para dias, horas, minutos e segundos.
            duracao = horarioFinalEmSegundos - horarioInicioEmSegundos;

            totalDias = duracao / (24 * 3600);
            duracao = duracao % (24 * 3600);
            totalHoras = duracao / 3600;
            duracao = duracao % 3600;
            totalMinutos = duracao / 60;
            totalSegundos = duracao % 60;

            Console.WriteLine($"{totalDias} dia(s)");
            Console.WriteLine($"{totalHoras} hora(s)");
            Console.WriteLine($"{totalMinutos} minuto(s)");
            Console.WriteLine($"{totalSegundos} segundo(s)");
        }
    }
}