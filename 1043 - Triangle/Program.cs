using System;
using System.Globalization;

namespace Beecrowd1043
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] valores = Console.ReadLine().Split(' ');
            double ladoA = Convert.ToDouble(valores[0],CultureInfo.InvariantCulture);
            double ladoB = Convert.ToDouble(valores[1],CultureInfo.InvariantCulture);
            double ladoC = Convert.ToDouble(valores[2],CultureInfo.InvariantCulture);

            if ( ladoA < ladoB + ladoC && ladoB < ladoA + ladoC && ladoC < ladoA + ladoB)
            {
                double perimetro = ladoA + ladoB + ladoC;
                Console.WriteLine($"Perimetro = {perimetro.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            else
            {
                double area = ((ladoA + ladoB) * ladoC) / 2;
                Console.WriteLine($"Area = {area.ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}