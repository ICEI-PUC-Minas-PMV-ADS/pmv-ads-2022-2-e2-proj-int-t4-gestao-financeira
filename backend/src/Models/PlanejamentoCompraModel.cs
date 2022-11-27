namespace Gestão_Financeira.Models
{
    public class PlanejamentoCompraModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataPrevistaCompra { get; set; }
        public bool DeveRepetir { get; set; }
        public float ValorPlanejado { get; set; }
        public bool Finalizado { get; set; }
        public ItemModel Item { get; set; }
        public int ItemId { get; set; }
    }
}
