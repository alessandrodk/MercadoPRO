using Business.Models;

namespace Business.Intefaces;

public interface ICategoriaService : IDisposable
{
    Task<bool> Adicionar(Categoria categoria);
    Task<bool> Atualizar(Categoria categoria);
    Task<bool> Remover(int id);
}
