using System;

namespace Beecrowd1103
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*                                        Alarm Clock

            Daniela é enfermeira em um grande hospital, o que faz com que seus turnos de trabalho mudem constantemente. Para piorar, ela dorme profundamente e tem uma grande dificuldade em acordar usando despertadores.

            Recentemente, ela recebeu um relógio digital como presente, com várias opções diferentes de sons de alarme, e espera que isso ajude a resolver seu problema. Mas ultimamente, ela está muito cansada e quer aproveitar cada momento de descanso. Então ela carrega seu novo relógio para todos os lugares que vai e, sempre que tem algum tempo livre, tenta dormir, configurando o despertador para o momento em que ela precisa acordar. Mas, com tanta ansiedade para dormir, ela acaba com alguma dificuldade para adormecer e descansar um pouco.

            Um problema que a atormenta é saber quantos minutos de sono ela teria se sentisse dormindo imediatamente e acordasse quando o despertador tocasse. Mas ela não é muito boa com números e pediu ajuda para escrever um programa que, dada a hora atual e a hora do alarme, descubra o número de minutos que ela conseguiu dormir. */



            int horaInicio, horaFinal, minutoInicio, minutoFinal, totalMinutos = 0;

            while(true)
            {
                string[] entradasHorarios = Console.ReadLine().Split(' ');
                horaInicio = Convert.ToInt32(entradasHorarios[0]);
                minutoInicio = Convert.ToInt32(entradasHorarios[1]);
                horaFinal = Convert.ToInt32(entradasHorarios[2]);
                minutoFinal = Convert.ToInt32(entradasHorarios[3]);

                if(horaInicio == 0 && horaFinal == 0 && horaFinal == 0 && minutoFinal == 0)
                {break;}

                if(horaInicio > horaFinal || horaInicio == horaFinal && minutoInicio > minutoFinal)
                {
                    horaFinal += 24;
                }

                totalMinutos = (horaFinal * 60 + minutoFinal) - (horaInicio * 60 + minutoInicio); // Convertendo horas para minutos = hora * 60.
                
                Console.WriteLine(totalMinutos);
            }


        }
    }
}