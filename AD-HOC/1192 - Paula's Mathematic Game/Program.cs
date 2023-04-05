using System;

namespace Beecrowd1192
{
    class Program
    {
        static void Main(string[] args)
        {

            int numeroDeTestes = Convert.ToInt32(Console.ReadLine());

            for(int contador = 0; contador < numeroDeTestes; contador++)
            {
                string teste = Console.ReadLine();
                int digito1 =  Convert.ToInt32(teste[0].ToString());
                char letra = Convert.ToChar(teste[1].ToString());
                int digito2 = Convert.ToInt32(teste[2].ToString());

                if(digito1 == digito2)
                {
                    Console.WriteLine(digito2 * digito1);
                }
                else
                {
                    if(Char.IsUpper(letra))
                    {
                        Console.WriteLine(digito2 - digito1);
                    }
                    else
                    {
                        Console.WriteLine(digito1 + digito2);
                    }
                }      

            }
        }
    }
}