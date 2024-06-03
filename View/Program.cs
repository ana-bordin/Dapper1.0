using Controllers;
using Models;

namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio");

            Pedido pedido = new Pedido
            {
                Id = 1,
                Descricao = "Quero Tudo",
                Mesa = 10
            };

            if (new PedidoController().Inserir(pedido))
            {
                Console.WriteLine("Pedido inserido com sucesso");
            }
            else
            {
                Console.WriteLine("Erro ao inserir pedido");
            }
        }
    }
}
