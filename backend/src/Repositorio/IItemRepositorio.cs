using Gestão_Financeira.Models;

namespace Gestão_Financeira.Repositorio
{
    public interface IItemRepositorio
    {
        public ItemModel Cadastrar(ItemModel item);
        public ItemModel Atualizar(ItemModel item);
        public ItemModel Consultar(int id);
        public void Deletar(ItemModel item);
    }
}
