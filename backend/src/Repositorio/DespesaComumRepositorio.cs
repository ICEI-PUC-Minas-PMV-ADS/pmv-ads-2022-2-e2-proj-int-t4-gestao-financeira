using Gestão_Financeira.Data;
using Gestão_Financeira.Models;

namespace Gestão_Financeira.Repositorio
{
    public class DespesaComumRepositorio : IDespesaComumRepositorio
    {
        private readonly BancoContext _context;

        public DespesaComumRepositorio(BancoContext context)
        {
            _context = context;
        }

        public DespesaComumModel Cadastrar(DespesaComumModel despesaComum)
        {
            _context.DespesasComuns.Add(despesaComum);
            _context.SaveChanges();
            return despesaComum;
        }

        public DespesaComumModel Atualizar(DespesaComumModel despesaComum)
        {
            _context.DespesasComuns.Update(despesaComum);
            _context.SaveChanges();
            return despesaComum;
        }

        public void Deletar(int id)
        {
            _context.DespesasComuns.Remove(_context.DespesasComuns.Where(x => x.Id == id).First());
            _context.SaveChanges();
        }

        public DespesaComumModel Consultar(int id)
        {
            return _context.DespesasComuns.Where(x => x.Id == id).First();
        }
    }
}
