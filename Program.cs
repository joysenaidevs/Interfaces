using System;
using Interfaces.classe;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();
            
            Produto produto = new Produto();

            produto.Nome = "Playstation 5";
            produto.Codigo = 123;
            produto.Preco = 10000;

            Produto produto1 = new Produto();

            produto1.Nome = "XBox Series X ";
            produto1.Codigo = 124;
            produto1.Preco = 1200;

            Produto produto2 = new Produto();

            produto2.Nome = "Nintendo";
            produto2.Codigo = 125;
            produto2.Preco = 400;

            carrinho.Cadastrar(produto);
            carrinho.Listar();

            carrinho.Cadastrar(produto1);
            

            //Alterar um produto

            carrinho.Alterar(produto.Codigo, produto2);
            carrinho.Listar();
        }
    }
}
