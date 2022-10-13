class SaldoConta
{
    public float Saldo { get; set; }
    public int IdUsuario { get; set; }

    public SaldoConta(float saldo)
    {
        Saldo = saldo;
    }

    public void Consultar(){}
    public void Depositar(){}
    public void Sacar(){}
    public void CriarTransacao(){}
}