using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Gestão_Financeira.Models
{
    public class TransacaoModel
    {
        public int Id { get; set; }
        public float Valor { get; set; }
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
