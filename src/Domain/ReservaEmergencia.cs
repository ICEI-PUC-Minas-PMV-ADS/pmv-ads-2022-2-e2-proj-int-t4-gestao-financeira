class ReservaEmergencia
{
    public string Nome { get; set; }
    public string Descricao { get; set; }

    public ReservaEmergencia(string nome, string descricao)
    {
        Nome = nome;
        Descricao = descricao;
    }

    public void Atualizar(nome, descricao) {}
    public void Deletar() {}
    public void ConsultarReserva() {}: ReservaEmergencia
    public void CriarTransacao(string tipoTransacao, float valor, boolean transacaoEmergencial) {}
}