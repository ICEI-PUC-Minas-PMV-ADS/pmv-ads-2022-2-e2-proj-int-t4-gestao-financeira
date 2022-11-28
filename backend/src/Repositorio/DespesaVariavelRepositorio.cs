using Gestão_Financeira.Data;
using Gestão_Financeira.Models;

namespace Gestão_Financeira.Repositorio
{
    public class DespesaVariavelRepositorio : IDespesaVariavelRepositorio
    {
        private readonly BancoContext _context;

        public DespesaVariavelRepositorio(BancoContext context)
        {
            _context = context;
        }

        public DespesaVariavelModel Cadastrar(DespesaVariavelModel despesaVariavel)
        {
            _context.DespesasVariaveis.Add(despesaVariavel);
            _context.SaveChanges();
            return despesaVariavel;
        }

        public DespesaVariavelModel Atualizar(DespesaVariavelModel despesaVariavel)
        {
            _context.DespesasVariaveis.Update(despesaVariavel);
            _context.SaveChanges();
            return despesaVariavel;
        }

        public DespesaVariavelModel Consultar(int id)
        {
            return _context.DespesasVariaveis.Where(x => x.Id == id).First();
        }

        public void Deletar(int id)
        {
            _context.DespesasVariaveis.Remove(_context.DespesasVariaveis.Where(x => x.Id == id).First());
            _context.SaveChanges();
        }
    }
}
