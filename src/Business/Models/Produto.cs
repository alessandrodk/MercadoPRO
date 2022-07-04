namespace Business.Models;

public class Produto : Entity
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public string ImagemUrl { get; set; }
    public int Quantidade { get; set; }
    public DateTime DataCadastro { get; set; }
    public int CategoriaId { get; set; }
    public Categoria Categoria { get; set; }

    public IEnumerable<PedidoDetalhe> PedidoDetalhes { get; set; }
}
