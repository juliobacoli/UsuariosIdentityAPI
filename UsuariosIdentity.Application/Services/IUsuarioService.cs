using UsuariosIdentity.Application.Data.DTOs;

namespace UsuariosIdentity.Application.Services;

public interface IUsuarioService
{
    Task CadastraUsuarioAsync(CreateUsuarioDTO dto);
}
