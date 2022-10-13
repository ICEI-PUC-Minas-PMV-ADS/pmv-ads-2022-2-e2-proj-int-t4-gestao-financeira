class Item
{
    public string Nome { get; set; }    
    public float Valor { get; set; }
    public int  Quantidade { get; set; }

    public Item(string nome, float valor, int quantidade)
    {
        Nome = nome;
        Valor = valor;
        Quantidade = quantidade;
    }
    
    public void Atualizar(){}
    public void Deletar(){}
    public Item Consultar(){}
}