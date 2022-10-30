
using System;
using System.ComponentModel.DataAnnotations;

namespace Gestão_Financeira.Models
{
    public class TransacaoModelRequest
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Insira um valor para essa transação!")]
        [MinLength(1)(ErrorMessage = "Insira um valor para essa transação!")]
        public float valor { get; set; }

        [Required(ErrorMessage = "Informe qual o Tipo de transação que está sendo realizado!")]
        public string tipoTransacao: { get; set }
        
        public DateTime dataTransacao { get; set; }

    };

    public class TransacaoModelResponse
    {
        public float newBalance: { get; set; }
        public List<TransactionHistory> transactionHistory: { get; set; }
    }
}
