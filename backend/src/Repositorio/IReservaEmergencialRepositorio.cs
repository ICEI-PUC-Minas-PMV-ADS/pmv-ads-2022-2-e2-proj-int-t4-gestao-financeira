using Gestão_Financeira.Models;

namespace Gestão_Financeira.Repositorio
{
    public interface IReservaEmergencialRepositorio
    {
        public ReservaEmergencialModel Cadastrar(ReservaEmergencialModel reservaEmergencial);
        public ReservaEmergencialModel Atualizar(ReservaEmergencialModel reservaEmergencial);
        public void Deletar(ReservaEmergencialModel reservaEmergencial);
    }
}
