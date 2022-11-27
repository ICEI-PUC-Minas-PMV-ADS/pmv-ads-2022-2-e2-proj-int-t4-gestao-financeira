using Gestão_Financeira.Data;
using Gestão_Financeira.Models;
using Microsoft.EntityFrameworkCore;

namespace Gestão_Financeira.Repositorio
{
    public class ItemRepositorio : IItemRepositorio
    {
        private readonly BancoContext _context;

        public ItemRepositorio(BancoContext context)
        {
            _context = context;
        }
        public ItemModel Cadastrar(ItemModel item)
        {
            _context.Itens.Add(item);
            _context.SaveChanges();
            return item;
        }

        public ItemModel Atualizar(ItemModel item)
        {
            _context.Itens.Update(item);
            _context.SaveChanges();
            return item;
        }

        public void Deletar(int id)
        {
            var itemId = _context.PlanejamentosCompras.Where(x => x.Id == id).First().ItemId;
            _context.Itens.Remove(_context.Itens.Where(x => x.Id == itemId).First());
            _context.SaveChanges();
        }

        public ItemModel Consultar(int id)
        {
            return _context.Itens.Where(x => x.Id == id).First();
        }
    }
}
