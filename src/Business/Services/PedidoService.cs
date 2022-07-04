using Business.Intefaces;
using Business.Models;
using Business.Models.Validations;

namespace Business.Services;

public class PedidoService : BaseService, IPedidoService
{
    private readonly IPedidoRepository _service;

    public PedidoService(IPedidoRepository service,
                             INotificador notificador) : base(notificador)
    {
        _service = service;
    }

    public async Task<bool> Adicionar(Pedido pedido)
    {
        if (_service.ObterTodos(f => f.Nome == pedido.Nome).Result.Any())
        {
            Notificar("Já existe um Pedido com este documento informado.");
            return false;
        }

        await _service.Adicionar(pedido);
        return true;
    }

    public async Task<bool> Atualizar(Pedido pedido)
    {
        if (!ExecutarValidacao(new PedidoValidation(), pedido)) return false;

        if (_service.ObterTodos(f => f.Nome == pedido.Nome && f.Id != pedido.Id).Result.Any())
        {
            Notificar("Já existe um Pedido com este documento infomado.");
            return false;
        }

        await _service.Atualizar(pedido);
        return true;
    }
 

    public async Task<bool> Remover(int id)
    {
        await _service.Remover(id);
        return true;
    }

    public void Dispose()
    {
        _service?.Dispose();
    }
}
