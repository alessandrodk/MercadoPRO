using Business.Models;

namespace Business.Intefaces;

public interface IPedidoDetalheService : IDisposable
{
    Task<bool> Adicionar(PedidoDetalhe pedidoDetalhe);
    Task<bool> Atualizar(PedidoDetalhe pedidoDetalhe);
    Task<bool> Remover(int id);
}