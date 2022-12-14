using Gestão_Financeira.Data;
using Gestão_Financeira.Models;

namespace Gestão_Financeira.Repositorio
{
    public class ReservaEmergencialRepositorio : IReservaEmergencialRepositorio
    {
        private readonly BancoContext _context;

        public ReservaEmergencialRepositorio(BancoContext context)
        {
            _context = context;
        }

        public ReservaEmergencialModel Cadastrar(ReservaEmergencialModel reservaEmergencial)
        {
            _context.ReservasEmergenciais.Add(reservaEmergencial);
            _context.SaveChanges();
            return reservaEmergencial;
        }

        public ReservaEmergencialModel Atualizar(ReservaEmergencialModel reservaEmergencial)
        {
            _context.ReservasEmergenciais.Update(reservaEmergencial);
            _context.SaveChanges();
            return reservaEmergencial;
        }

        public void Deletar(int id)
        {
            _context.ReservasEmergenciais.Remove(_context.ReservasEmergenciais.Where(x => x.Id == id).First());
            _context.SaveChanges();
        }
    }
}
