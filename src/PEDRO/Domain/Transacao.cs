public class Transacao
{
    public string TipoTransacao { get; set; }
    public boolean TransacaoEmergencial { get; set; }
    public float Valor { get; set; }
    public DateTime DataTransacao { get; set; }
}