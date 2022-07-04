using Business.Intefaces;
using Business.Models;
using Business.Models.Validations;

namespace Business.Services;

public class ProdutoService : BaseService, IProdutoService
{
    private readonly IProdutoRepository _produtoRepository;
    private readonly IUser _user;

    public ProdutoService(IProdutoRepository produtoRepository,
                          INotificador notificador) : base(notificador)
    {
        _produtoRepository = produtoRepository;
    }

    public async Task<bool> Adicionar(Produto produto)
    {
        if (!ExecutarValidacao(new ProdutoValidation(), produto)) return false;

        await _produtoRepository.Adicionar(produto);
        return true;
    }

    public async Task<bool> Atualizar(Produto produto)
    {
        if (!ExecutarValidacao(new ProdutoValidation(), produto)) return false;

        await _produtoRepository.Atualizar(produto);
        return true;
    }

    public async Task<bool> Remover(int id)
    {
        var obj = new Produto { Id = id };
        await _produtoRepository.Remover(obj);
        return true;
    }

        public void Dispose() => _produtoRepository?.Dispose();
}
