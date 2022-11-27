using Gestão_Financeira.Models;

namespace Gestão_Financeira.Repositorio
{
    public interface IObjetivoFinanceiroRepositorio
    {
        public ObjetivoFinanceiroModel Cadastrar(ObjetivoFinanceiroModel objetivoFinanceiro);
        public ObjetivoFinanceiroModel Atualizar(ObjetivoFinanceiroModel objetivoFinanceiro);
        public ObjetivoFinanceiroModel Consultar(int id);
        public void Deletar(int id);
    }
}
