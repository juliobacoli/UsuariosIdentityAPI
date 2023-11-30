using UsuariosIdentity.Domain.Models;

namespace UsuariosIdentity.Application.Services;

public interface ITokenService
{
    Task<string> GerarToken(Usuario user);
}
