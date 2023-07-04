using System;

namespace Beecrowd1095
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 60;

            for(int contador = j; contador >= 0; contador-=5)
            {
                Console.WriteLine($"I={i} J={contador}");
                i += 3;
            }

        }
    }
}