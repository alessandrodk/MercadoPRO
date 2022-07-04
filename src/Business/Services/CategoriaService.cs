using Business.Intefaces;
using Business.Models;
using Business.Models.Validations;
using Business.Services;

namespace Business.Services;

public class CategoriaService : BaseService, ICategoriaService
{
    private readonly ICategoriaRepository _service;

    public CategoriaService(ICategoriaRepository service,
                             INotificador notificador) : base(notificador)
    {
        _service = service;
    }

    public async Task<bool> Adicionar(Categoria categoria)
    {
        if (_service.ObterTodos(f => f.Descricao == categoria.Descricao).Result.Any())
        {
            Notificar("Já existe um Categoria com este documento informado.");
            return false;
        }

        await _service.Adicionar(categoria);
        return true;
    }

    public async Task<bool> Atualizar(Categoria categoria)
    {
        if (!ExecutarValidacao(new CategoriaValidation(), categoria)) return false;

        if (_service.ObterTodos(f => f.Descricao == categoria.Descricao && f.Id != categoria.Id).Result.Any())
        {
            Notificar("Já existe um Categoria com este documento infomado.");
            return false;
        }

        await _service.Atualizar(categoria);
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
