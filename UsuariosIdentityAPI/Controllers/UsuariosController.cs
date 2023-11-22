using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UsuariosIdentity.Application.Data.DTOs;
using UsuariosIdentity.Domain.Models;

namespace UsuariosIdentityAPI.Controllers;

[ApiController]
public class UsuariosController : Controller
{
    private readonly IMapper _mapper;
    private readonly UserManager<Usuario> _userManager;

    public UsuariosController(IMapper mapper, UserManager<Usuario> userManager)
    {
        _mapper = mapper;
        _userManager = userManager;
    }

    [HttpPost]
    [Route("api/cadastraUsuario")]
    public async Task<IActionResult> CadastraUsuario(CreateUsuarioDTO dto)
    {
        Usuario usuario = _mapper.Map<Usuario>(dto);

        var result = await _userManager.CreateAsync(usuario, dto.Password);

        if (result.Succeeded)
            return Ok("Usuário cadastrado.");
        return BadRequest("Falha ao cadastrar usuário.");

    }
}
