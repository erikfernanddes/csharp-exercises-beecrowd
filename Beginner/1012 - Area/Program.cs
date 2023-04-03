using System;

namespace Beecrowd1012
{
    class Program
    {
        static void Main(string[] args){

            string [] vet = Console.ReadLine().Split(' ');
            double A = Convert.ToDouble(vet[0]);
            double B = Convert.ToDouble(vet[1]);
            double C = Convert.ToDouble(vet[2]);
            double PI = 3.14159 ;

            double triangulo = A * C / 2; // Area do triangulo é o produto do lado A e C dividido por dois
            double circulo = PI * Math.Pow(C, 2); //A área do circulo é o produto de PI e C²
            double trapezio = (A + B) / 2 * C; // A área do trapézio é o soma das bases (A e B) dividida por dois e multiplicada pela altura(C)
            // double quadrado = ;
            double quadrado = Math.Pow(B, 2) ; // A área do quadrado é a exponenciação de um dos seus lados iguais.
            double retangulo = A * B ; // Nesse exemplo. é o produto entre o lado A e B

            Console.WriteLine($"TRIANGULO: {triangulo:F3}");
            Console.WriteLine($"CIRCULO: {circulo:F3}");
            Console.WriteLine($"TRAPEZIO: {trapezio:F3}");
            Console.WriteLine($"QUADRADO: {quadrado:F3}");
            Console.WriteLine($"RETANGULO: {retangulo:F3}");
        }
    }
}