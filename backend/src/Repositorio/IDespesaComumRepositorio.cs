using Gestão_Financeira.Models;


namespace Gestão_Financeira.Repositorio
{
    public interface IDespesaComumRepositorio
    {
        public DespesaComumModel Cadastrar(DespesaComumModel despesaComum);
        public DespesaComumModel Atualizar(DespesaComumModel despesaComum);
        public DespesaComumModel Consultar(int id);
        public void Deletar(int id);
    }
}
