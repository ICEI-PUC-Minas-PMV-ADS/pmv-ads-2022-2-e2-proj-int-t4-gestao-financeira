class PlanejamentoCompra
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public DateTime DataPrevistaCompra { get; set; }
    public boolean DeveRepetir { get; set; }
    public float ValorPlanejado { get; set; }
    public boolean Finalizado { get; set; }
    public int IdItem { get; set; }
    public int IdUsuario { get; set; }
    public int IdSaldo { get; set; }

    public PlanejamentoCompra(string nome, string descricao, DateTime dataPrevistaCompra, boolean deveRepetir,
        float valorPlanejado, boolean finalizado)
    {
        Nome = nome;
        Descricao = descricao;
        DataPrevistaCompra = dataPrevistaCompra;
        DeveRepetir = deveRepetir;
        ValorPlanejado = valorPlanejado;
        Finalizado = finalizado;
    }

    public void Atualizar(id, nome, descricao, dataFinalObjetivo) {}
    public void deletar() {}
    public PlanejamentoCompra consultar() {}
}