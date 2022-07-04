using System.Security.Claims;

namespace Business.Intefaces;

public interface IUser
{
    string Name { get; }
    Guid ObterUsuarioId();
    string ObterEmailUsuario();
    bool EstaAutenticado();
    bool IsInRole(string role);
    IEnumerable<Claim> ObterClaim();
}
