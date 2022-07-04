namespace Business.Models;

public class Pedido : Entity
{
    public string UsuarioId { get; set; }
    //public Usuario Usuario { get; set; }
    public DateTime DataPedido { get; set; }
    public decimal ValorTotal { get; set; }
    public string StatusPedido { get; set; }
    public string StatusPagamento { get; set; }
    public string Telefone { get; set; }
    public string Endereco { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string CEP { get; set; }
    public string Nome { get; set; }

    public IEnumerable<PedidoDetalhe> PedidoDetalhes { get; set; }
}
