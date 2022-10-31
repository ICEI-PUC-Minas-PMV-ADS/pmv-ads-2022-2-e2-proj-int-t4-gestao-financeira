using Gestão_Financeira.Models;

namespace Gestão_Financeira.Repositorio
{
    public interface ITransacaoRepositorio
    {
        public TransacaoModel Depositar(TransacaoModel transacao);
        public TransacaoModel Sacar(TransacaoModel transacao);
    }
}
