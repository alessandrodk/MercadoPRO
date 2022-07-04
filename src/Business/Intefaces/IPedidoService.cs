using Business.Models;

namespace Business.Intefaces;

public interface IPedidoService : IDisposable
{
    Task<bool> Adicionar(Pedido pedido);
    Task<bool> Atualizar(Pedido pedido);
    Task<bool> Remover(int id);
}
