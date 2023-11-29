using Microsoft.AspNetCore.Mvc;
using UsuariosIdentity.Application.Data.DTOs;
using UsuariosIdentity.Application.Services;
using UsuariosIdentity.Domain.Models;
using UsuariosIdentity.Domain.Models.DTOs;

namespace UsuariosIdentityAPI.Controllers;

[ApiController]
public class UsuariosController : Controller
{

    private readonly UsuarioService _usuarioService;
    private readonly TokenService _tokenService;

    public UsuariosController(UsuarioService usuarioService, TokenService tokenService)
    {
        _usuarioService = usuarioService;
        _tokenService = tokenService;
    }

    [HttpPost]
    [Route("api/cadastraUsuario")]
    [ProducesResponseType(typeof(string), 200)]
    public async Task<IActionResult> CadastraUsuario(CreateUsuarioDTO dto)
    {
        await _usuarioService.CadastraUsuarioAsync(dto);
        return Ok("Usuário cadastrado");
    }

    [HttpPost]
    [Route("api/Login")]
    [ProducesResponseType(typeof(string), 200)]
    public async Task<IActionResult> Login(LoginUsuarioDTO dto, Usuario user)
    {
        await _usuarioService.LoginAsync(dto);

        await _tokenService.GerarToken(user);
        return Ok();
    }
}
