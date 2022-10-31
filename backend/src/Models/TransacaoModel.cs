using System.ComponentModel.DataAnnotations;

namespace Gestão_Financeira.Models
{
    public class TransacaoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Insira um valor para essa transação!")]
        [MinLength(1, ErrorMessage = "Insira um valor para essa transação!")]
        public float Valor { get; set; }
        [Required(ErrorMessage = "Informe qual o Tipo de transação que está sendo realizado!")]
        public string TipoTransacao { get; set; }
        public DateTime DataTransacao { get; set; }
    };

    public class TransacaoModelResponse
    {
        public float NovoSaldo { get; set; }
        public List<TransacaoModel> HistoricoTransacao { get; set; }

        public TransacaoModelResponse()
        {
            HistoricoTransacao = new List<TransacaoModel>();
        }
    }
}
