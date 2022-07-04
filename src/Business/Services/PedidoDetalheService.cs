using Business.Intefaces;
using Business.Models;
using Business.Models.Validations;

namespace Business.Services;

public class PedidoDetalheService : BaseService, IPedidoDetalheService
{
    private readonly IPedidoDetalheRepository _service;

    public PedidoDetalheService(IPedidoDetalheRepository service,
                             INotificador notificador) : base(notificador)
    {
        _service = service;
    }

    public async Task<bool> Adicionar(PedidoDetalhe PedidoDetalhe)
    {
        if (_service.ObterTodos(f => f.PedidoId == PedidoDetalhe.PedidoId).Result.Any())
        {
            Notificar("Já existe um PedidoDetalhe com este documento informado.");
            return false;
        }

        await _service.Adicionar(PedidoDetalhe);
        return true;
    }

    public async Task<bool> Atualizar(PedidoDetalhe PedidoDetalhe)
    {
        if (!ExecutarValidacao(new PedidoDetalheValidation(), PedidoDetalhe)) return false;

        if (_service.ObterTodos(f => f.PedidoId == PedidoDetalhe.PedidoId && f.Id != PedidoDetalhe.Id).Result.Any())
        {
            Notificar("Já existe um PedidoDetalhe com este documento infomado.");
            return false;
        }

        await _service.Atualizar(PedidoDetalhe);
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
