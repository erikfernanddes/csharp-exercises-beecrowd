using System;


namespace BeeCrowd1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ponto1 = Console.ReadLine().Split(' ');
            double x1 = Convert.ToDouble(ponto1[0]);
            double y1 = Convert.ToDouble(ponto1[1]);

            string[] ponto2 = Console.ReadLine().Split(' ');
            double x2 = Convert.ToDouble(ponto2[0]);
            double y2 = Convert.ToDouble(ponto2[1]);



            double distancia = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
            distancia = Math.Sqrt(distancia);

            Console.WriteLine($"{distancia:F4}");

        }
    }
}