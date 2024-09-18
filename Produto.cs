using System.Data;

namespace BookTrack.Core;

public class Produto
{
    public string Nome { get; set; }

    public double Preco { get; set; }

    public string Marca { get; set; }

    public string Categoria { get; set; }

    public string CodigoProduto { get; set; }

    public int EstoqueQuantidade { get; set; }

    public DateTime DataFabricacao { get; set; }

    public Produto (string nome, 
    double preco, 
    string marca, 
    string categoria, 
    string codigoproduto, 
    int EstoqueQuantidade) {

        Nome = nome;
        Preco = preco;
        Marca = marca;
        Categoria = categoria;
        CodigoProduto = codigoproduto;
        EstoqueQuantidade = 0;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Preço: {Preco}, Marca: {Marca}, Categoria do Produto: {Categoria}, Codigo do Produto: {CodigoProduto}, Estoque Quantidade: {EstoqueQuantidade}";
    }
}