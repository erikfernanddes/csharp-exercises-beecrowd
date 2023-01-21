using System;

namespace Beecrowd1002
{
    class Program
    {
        static void Main (string[] args)
        {
            double n = 3.14159;
            double r = Convert.ToDouble(Console.ReadLine());
            double a = n * Math.Pow(r, 2);

            Console.WriteLine($"A={a:F4}"); 

        }
    }
}