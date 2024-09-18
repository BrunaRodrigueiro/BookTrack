using System.Data;

namespace BookTrack.Core;

public class Estoque
{
    private List<Produto> produtos = new List<Produto>();
    
    public void NovoProduto() {
        
        Console.WriteLine ("Digite o nome do Produto: ");
        string nome = Console.ReadLine();
        
        Console.WriteLine ("Digite o preço do Produto: ");
        double preco = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine ("Digite a marca do Produto: ");
        string marca = Console.ReadLine();

        Console.WriteLine ("Digite a categoria do Produto: ");
        string categoria = Console.ReadLine();

        Console.WriteLine ("Digite o código do Produto: ");
        string codigoproduto = Console.ReadLine();

        Produto produto = new Produto(nome, preco, marca, categoria, codigoproduto, 0);
        produtos.Add(produto);
        Console.WriteLine("Produto adicionado com sucesso!");

    } 
        public void ListarProdutos()
        {
            Console.WriteLine("Produtos no estoque:");
            foreach (var produto in produtos)
            {
                Console.WriteLine($"Nome: {produto.Nome}, Quantidade: {produto.EstoqueQuantidade}");
            }
        }

            public void RemoverProduto()
        {
            Console.WriteLine("Digite o nome do produto a ser removido:");
            string nome = Console.ReadLine();

            Produto produtoARemover = produtos.Find(p => p.Nome == nome);
            if (produtoARemover != null)
            {
                produtos.Remove(produtoARemover);
                Console.WriteLine("Produto removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado!");
            }
        }

        public void EntradaEstoque()
        {
            Console.WriteLine("Digite o nome do produto:");
            string nome = Console.ReadLine();

            Produto produto = produtos.Find(p => p.Nome == nome);
            if (produto != null)
            {
                Console.WriteLine("Digite a quantidade de entrada:");
                int quantidade = int.Parse(Console.ReadLine());

                produto.EstoqueQuantidade += quantidade;
                Console.WriteLine("Entrada realizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado!");
            }
        }

        public void SaidaEstoque()
        {
            Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            Produto produto = produtos.Find(p => p.Nome == nome);
            if (produto != null)
            {
                Console.WriteLine("Digite a quantidade de saída: ");
                int quantidade;
                while (!int.TryParse(Console.ReadLine(), out quantidade));
                {
                    Console.WriteLine("Quantidade inválida. Digite novamente: ");
                }

                if (quantidade <= produto.EstoqueQuantidade)
                {
                    produto.EstoqueQuantidade -= quantidade;
                    Console.WriteLine("Saída realizada com sucesso!");
                }
                else
                {
                    Console.WriteLine("Quantidade insuficiente em estoque!");
                }
            }
            else
            {
                Console.WriteLine("Produto não encontrado!");
            }
        }

        public void Sair()
        {
            Console.WriteLine("Saindo do sistema...");
            Environment.Exit(0);
        }
}