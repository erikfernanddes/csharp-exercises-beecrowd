using System;


namespace beecrowd1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, r1, r2, delta;
            string[] valores = Console.ReadLine().Split(' ');

            a = Convert.ToDouble(valores[0]);
            b = Convert.ToDouble(valores[1]);
            c = Convert.ToDouble(valores[2]);

            delta = Math.Pow(b, 2) - (4 * a * c);

            r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            r2 = (-b - Math.Sqrt(delta)) / (2 * a);

            if(a != 0 && delta > 0)
            {
                Console.WriteLine($"R1 = {r1:F5}");
                Console.WriteLine($"R2 = {r2:F5}");

            }
            else
            {
                Console.WriteLine("Impossivel calcular");

            }
 
        }
    }   
}
