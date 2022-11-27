using Gestão_Financeira.Data;
using Gestão_Financeira.Models;

namespace Gestão_Financeira.Repositorio
{
    public class PlanejamentoCompraRepositorio : IPlanejamentoCompraRepositorio
    {
        private readonly BancoContext _context;

        public PlanejamentoCompraRepositorio(BancoContext context)
        {
            _context = context;
        }
        public PlanejamentoCompraModel Cadastrar(PlanejamentoCompraModel planejamentoCompra)
        {
            _context.PlanejamentosCompras.Add(planejamentoCompra);
            _context.SaveChanges();
            return planejamentoCompra;
        }

        public PlanejamentoCompraModel Atualizar(PlanejamentoCompraModel planejamentoCompra)
        {
            _context.PlanejamentosCompras.Update(planejamentoCompra);
            _context.SaveChanges();
            return planejamentoCompra;
        }

        public PlanejamentoCompraModel Consultar(int id)
        {
            return _context.PlanejamentosCompras.Where(x => x.Id == id).First();
        }

        public void Deletar(PlanejamentoCompraModel planejamentoCompra)
        {
            _context.PlanejamentosCompras.Remove(planejamentoCompra);
            _context.SaveChanges();
        }
    }
}
