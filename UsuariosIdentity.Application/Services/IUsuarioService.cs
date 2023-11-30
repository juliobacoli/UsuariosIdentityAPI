using UsuariosIdentity.Application.Data.DTOs;
using UsuariosIdentity.Domain.Models.DTOs;

namespace UsuariosIdentity.Application.Services;

public interface IUsuarioService
{
    Task CadastraUsuarioAsync(CreateUsuarioDTO dto);
    Task<string> LoginAsync(LoginUsuarioDTO dto);
}
