using Gestão_Financeira.Data;
using Gestão_Financeira.Models;

namespace Gestão_Financeira.Repositorio
{
    public class ObjetivoFinanceiroRepositorio : IObjetivoFinanceiroRepositorio
    {
        private readonly BancoContext _context;

        public ObjetivoFinanceiroRepositorio(BancoContext context)
        {
            _context = context;
        }
        public ObjetivoFinanceiroModel Cadastrar(ObjetivoFinanceiroModel objetivoFinanceiro)
        {
            _context.ObjetivosFinanceiros.Add(objetivoFinanceiro);
            _context.SaveChanges();
            return objetivoFinanceiro;
        }

        public ObjetivoFinanceiroModel Atualizar(ObjetivoFinanceiroModel objetivoFinanceiro)
        {
            _context.ObjetivosFinanceiros.Update(objetivoFinanceiro);
            _context.SaveChanges();
            return objetivoFinanceiro;
        }

        public ObjetivoFinanceiroModel Consultar(int id)
        {
            return _context.ObjetivosFinanceiros.Where(x => x.Id == id).First();
        }

        public void Deletar(ObjetivoFinanceiroModel objetivoFinanceiro)
        {
            _context.ObjetivosFinanceiros.Remove(objetivoFinanceiro);
            _context.SaveChanges();
        }
    }
}
