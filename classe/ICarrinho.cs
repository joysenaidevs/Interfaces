namespace Interfaces.classe
{
    public interface ICarrinho
    {
         // todas as interfaces terao que começar com a letra I maiuscula
         //não há modificador de acesso - ex: public, private...

         //primeiro metodo do CRUD

         //Create - Cadastrar
         void Cadastrar(Produto produto);

         //Read - Ler
         void Listar();

         // Update - Alterar
         void Alterar(int codigo, Produto produto);

         //Delete - Deletar
         void Deletar(Produto produto);

    }
}