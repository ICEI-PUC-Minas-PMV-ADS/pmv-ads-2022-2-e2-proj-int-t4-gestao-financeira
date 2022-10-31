namespace Gestão_Financeira.Models
{
    public class SaldoContaModel
    {
        public int Id { get; set; }
        public float Saldo { get; set; }
        public int IdUsuario { get; set; }

        public SaldoContaModel()
        {
            Saldo = 0;
        }
    }
}
