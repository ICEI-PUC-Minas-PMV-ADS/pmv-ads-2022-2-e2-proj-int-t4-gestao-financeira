using Gestão_Financeira.Models;

namespace Gestão_Financeira.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UserModel Adicionar(UserModel usuario);
        UserModel BuscarLogin(string email);
        
    }
}
