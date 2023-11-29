using UsuariosIdentity.Domain.Models;

namespace UsuariosIdentity.Application.Services;

public interface ITokenService
{
    Task GerarToken(Usuario user);
}
