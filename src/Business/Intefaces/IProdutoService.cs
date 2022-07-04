using Business.Models;

namespace Business.Intefaces;

public interface IProdutoService : IDisposable
{
    Task<bool> Adicionar(Produto produto);
    Task<bool> Atualizar(Produto produto);
    Task<bool> Remover(int id);
}
