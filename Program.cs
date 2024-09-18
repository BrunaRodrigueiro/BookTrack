using System.Data;

namespace BookTrack.Core;

public class Program
{
    static void Main(string [] args) {

        Estoque estoque = new Estoque();
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("************************\n");

            Console.WriteLine("Escolha uma opção: \n");
            Console.WriteLine("[1] Novo");
            Console.WriteLine("[2] Listar Produtos");
            Console.WriteLine("[3] Remover Produtos");
            Console.WriteLine("[4] Entrada de Estoque");
            Console.WriteLine("[5] Saída Estoque");
            Console.WriteLine("[0] Sair\n");

            Console.WriteLine("************************");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                estoque.NovoProduto();
                break;

                case "2":
                estoque.ListarProdutos();
                break;

                case "3":
                estoque.RemoverProduto();
                break;

                case "4":
                estoque.EntradaEstoque();
                break;

                case "5":
                estoque.SaidaEstoque();
                break;

                case "0":
                estoque.Sair();
                break;

                default:
                Console.WriteLine("Opação inválida!");
                break;
            }
        }
    }


}
