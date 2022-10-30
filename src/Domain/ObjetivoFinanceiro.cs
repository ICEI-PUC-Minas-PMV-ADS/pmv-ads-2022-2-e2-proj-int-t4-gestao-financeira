class ObjetivoFinanceiro
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public DateTime DataFinalObjetivo { get; set; }
    public float ValorObjetivo { get; set; }
    public int IdUsuario { get; set; }
    public int IdSaldo { get; set; }

    public ObjetivoFinanceiro(string nome, string descricao, DateTime dataFinalObjetivo, float valorObjetivo)
    {
        Nome = nome; 
        Descricao = descricao; 
        DataFinalObjetivo = dataFinalObjetivo;
        ValorObjetivo = valorObjetivo;
    }

    public void Atualizar (id, nome, descricao, dataFinalObjetivo){}
    public void Deletar (){}
    public void Consultar(){}
    
}