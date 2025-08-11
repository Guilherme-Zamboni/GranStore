namespace GranStore.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }
        public int QtdeEstoque { get; set; }
        public decimal ValorCusto { get; set; }
        public decimal ValorVenda { get; set; }
    }
}