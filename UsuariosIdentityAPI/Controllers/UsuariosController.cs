using Microsoft.AspNetCore.Mvc;
using UsuariosIdentity.Application.Data.DTOs;
using UsuariosIdentity.Application.Services;

namespace UsuariosIdentityAPI.Controllers;

[ApiController]
public class UsuariosController : Controller
{

    private readonly UsuarioService _usuarioService;

    public UsuariosController(UsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    [HttpPost]
    [Route("api/cadastraUsuario")]
    public async Task<IActionResult> CadastraUsuario(CreateUsuarioDTO dto)
    {
        await _usuarioService.CadastraUsuarioAsync(dto);
        return Ok();
    }
}
