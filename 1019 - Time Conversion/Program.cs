using System;

namespace Beecrowd1019
{
    class Program
    {
        static void Main(string[] args)
        {

            int segundos, minuto, hora;
            segundos = Convert.ToInt32(Console.ReadLine());

            hora = segundos / 3600; //Obtendo apenas a parte inteira.
            int restoSegundos = segundos % 3600;

            minuto = restoSegundos / 60;
            restoSegundos = restoSegundos % 60;

            Console.WriteLine($"{hora}:{minuto}:{restoSegundos}");
        }
    }   
}
