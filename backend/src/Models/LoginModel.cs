using System.ComponentModel.DataAnnotations;

namespace Gestão_Financeira.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o e-mail!")]
        public string Email1 { get; set; }
        [Required(ErrorMessage = "Digite a senha!")]
        public string Senha { get; set; }
    }
}
