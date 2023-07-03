using System;

namespace Beecrowd1094
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Experiments

/*
    Maria has just started as graduate student in a medical school and she's needing your help to organize a laboratory experiment which she is responsible about. 
    She wants to know, at the end of the year, how many animals were used in this laboratory and the percentage of each type of animal is used at all.

This laboratory uses in particular three types of animals: frogs, rats and rabbits. To obtain this information, it knows exactly the number of experiments that were 
performed, the type and quantity of each animal is used in each experiment.
*/
#endregion

            string[] entradaAnimal;
            int quantidade, quantidadeCoelhos = 0, quantidadeRatos = 0, quantidadeSapos = 0;
            double totalAnimais = 0;
            char animal;
            int numeroDeTestes = Convert.ToInt32(Console.ReadLine());

            for(int contador = 0; contador < numeroDeTestes; contador++)
            {
                entradaAnimal = Console.ReadLine().Split(' ');
                quantidade = Convert.ToInt32(entradaAnimal[0]);
                animal = Convert.ToChar(entradaAnimal[1].ToUpper());

                totalAnimais += quantidade;

                if(animal == 'C')
                {
                    quantidadeCoelhos += quantidade;

                }else if(animal == 'R')
                {
                    quantidadeRatos += quantidade;

                }else if(animal == 'S')
                {
                    quantidadeSapos += quantidade;
                }

            }

           Console.WriteLine($"Total: {totalAnimais} cobaias");
           Console.WriteLine($"Total de coelhos: {quantidadeCoelhos}");
           Console.WriteLine($"Total de ratos: {quantidadeRatos}");
           Console.WriteLine($"Total de sapos: {quantidadeSapos}");

           Console.WriteLine($"Percentual de coelhos: {(quantidadeCoelhos / totalAnimais * 100).ToString("F2")} %");
           Console.WriteLine($"Percentual de ratos: {(quantidadeRatos / totalAnimais * 100).ToString("F2")} %");
           Console.WriteLine($"Percentual de sapos: {(quantidadeSapos / totalAnimais * 100).ToString("F2")} %");

        }

    }
}
