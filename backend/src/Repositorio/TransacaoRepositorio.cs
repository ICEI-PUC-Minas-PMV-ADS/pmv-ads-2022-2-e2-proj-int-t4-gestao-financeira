using Gestão_Financeira.Data;
using Gestão_Financeira.Models;

namespace Gestão_Financeira.Repositorio
{
    public class TransacaoRepositorio : ITransacaoRepositorio
    {
        private readonly BancoContext _context;

        public TransacaoRepositorio(BancoContext context)
        {
            _context = context;
        }

        public TransacaoModel Depositar(TransacaoModel transacao)
        {
            _context.Transacoes.Add(transacao);
            _context.SaveChanges();
            return transacao;
        }

        public TransacaoModel Sacar(TransacaoModel transacao)
        {
            _context.Transacoes.Add(transacao);
            _context.SaveChanges();
            return transacao;
        }
    }
}
