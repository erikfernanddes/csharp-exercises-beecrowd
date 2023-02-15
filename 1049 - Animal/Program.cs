using System;

namespace Beecrowd1049
{
    class Program
    {
        static void Main(string[] args)
        {

            string grupoFilo = Console.ReadLine().ToLower();
            string classe = Console.ReadLine().ToLower();
            string caracteristica = Console.ReadLine().ToLower();
            string animal = "";

            if(grupoFilo == "vertebrado")
            {
                if(classe == "ave")
                {
                    if(caracteristica == "carnivoro")
                    {
                        animal = "aguia";
                    }
                    else if(caracteristica == "onivoro")
                    {
                        animal = "pomba";
                    }
                }
                else if(classe == "mamifero")
                {
                    if(caracteristica == "onivoro")
                    {
                        animal = "homem";
                    }
                    else if(caracteristica == "herbivoro")
                    {
                        animal = "vaca";
                    }
                }
            }
            else if(grupoFilo == "invertebrado")
            {
                if(classe == "inseto")
                {
                    if(caracteristica == "hematofago")
                    {
                        animal = "pulga";
                    }
                    else if(caracteristica == "herbivoro")
                    {
                        animal = "lagarta";
                    }
                }
                else if (classe == "anelideo")
                {
                    if(caracteristica == "hematofago")
                    {
                        animal = "sanguessuga";
                    }
                    else if(caracteristica == "onivoro")
                    {
                        animal = "minhoca";
                    }
                }
            }

            Console.WriteLine(animal);
            Console.Read();

        }
    }
}
