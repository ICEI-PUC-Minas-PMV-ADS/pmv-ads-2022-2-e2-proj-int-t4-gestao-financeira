using Gestão_Financeira.Data;
using Gestão_Financeira.Models;

namespace Gestão_Financeira.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly BancoContext _context;
        public UsuarioRepositorio(BancoContext bancoContext)
        {
            this._context = bancoContext;
        }
        public UserModel Adicionar(UserModel usuario)
        {
            //gravar no db
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return usuario;
        }

        public UserModel BuscarLogin(string email)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Email == email);
        }
    }
}
