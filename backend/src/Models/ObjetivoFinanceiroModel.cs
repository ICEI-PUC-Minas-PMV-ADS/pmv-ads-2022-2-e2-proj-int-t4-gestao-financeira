namespace Gestão_Financeira.Models
{
    public class ObjetivoFinanceiroModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataFinalObjetivo { get; set; }
        public float ValorObjetivo { get; set; }
        public int IdUsuario { get; set; }
        public int IdSaldo { get; set; }
    }
}
