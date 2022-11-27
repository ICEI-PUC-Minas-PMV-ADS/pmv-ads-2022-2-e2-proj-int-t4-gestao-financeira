using Gestão_Financeira.Models;

namespace Gestão_Financeira.Repositorio
{
    public interface IPlanejamentoCompraRepositorio
    {
        public PlanejamentoCompraModel Cadastrar(PlanejamentoCompraModel planejamentoCompra);
        public PlanejamentoCompraModel Atualizar(PlanejamentoCompraModel planejamentoCompra);
        public PlanejamentoCompraModel Consultar(int id);
        public void Deletar(PlanejamentoCompraModel planejamentoCompra);
    }
}
