
using System;
using System.ComponentModel.DataAnnotations;

namespace Gestão_Financeira.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do usuário!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o apelido do usuário!")]
        public string Apelido { get; set; }
        [Required(ErrorMessage = "Digite a senha do usuário!")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Digite o e-mail do usuário!")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é valido!")]
        public string Email { get; set; }


        public bool SenhaValida(string senha)
        {
            return Senha == senha;
        }

    }
}
