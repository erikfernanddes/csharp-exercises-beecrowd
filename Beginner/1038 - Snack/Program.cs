using System;

namespace Beecrowd1038
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal PrecoCachorroQuente = 4.00M;
            decimal PrecoXsalada = 4.50M;
            decimal PrecoXbacon = 5.00M;
            decimal PrecoTorradasSimples = 2.00M;
            decimal PrecoRefrigerante = 1.50M;
            decimal valorTotal = 0;

            string[] pedido = Console.ReadLine().Split(' ');
            int codigoProduto = Convert.ToInt32(pedido[0]);
            int quantidade = Convert.ToInt32(pedido[1]);

            switch (codigoProduto)
            {
                case 1:
                    valorTotal = PrecoCachorroQuente * quantidade; break;
                case 2:
                    valorTotal = PrecoXsalada * quantidade; break;
                case 3:
                    valorTotal = PrecoXbacon * quantidade; break;
                case 4:
                    valorTotal = PrecoTorradasSimples * quantidade; break;
                case 5:
                    valorTotal = PrecoRefrigerante * quantidade; break;
            }

            Console.WriteLine($"Total: R$ {valorTotal.ToString("F2")}");
           
        }
    }
}
