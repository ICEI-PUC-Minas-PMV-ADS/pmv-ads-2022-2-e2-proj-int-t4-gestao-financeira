using Gestão_Financeira.Models;


namespace Gestão_Financeira.Repositorio
{
    public interface IDespesaVariavelRepositorio
    {
        public DespesaVariavelModel Cadastrar(DespesaVariavelModel despesaVariavel);
        public DespesaVariavelModel Atualizar(DespesaVariavelModel despesaVariavel);
        public DespesaVariavelModel Consultar(int id);
        public void Deletar(int id);
    }
}
