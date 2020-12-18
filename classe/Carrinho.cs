using System;
using System.Collections.Generic;

namespace Interfaces.classe
{
    public class Carrinho : ICarrinho
    {

        List<Produto> carrinho = new List<Produto>();

        public void Alterar(int codigo, Produto produto)
        {
            //posso utilizar o produto no lugar de x também
            carrinho.Find(x => x.Codigo == codigo).Nome = produto.Nome;
            carrinho.Find(x => x.Codigo == codigo).Preco = produto.Preco;
            
        }

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Deletar(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void Listar(){

            foreach (Produto itemCarrinho in carrinho){
                Console.WriteLine($"Produto {itemCarrinho.Nome} \n Preco: R$ {itemCarrinho.Preco} \n Codigo {itemCarrinho.Codigo}");
            }
        }
        
            
    }
}