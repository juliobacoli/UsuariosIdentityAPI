using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UsuariosIdentity.Application.Data.DTOs;
using UsuariosIdentity.Application.Services;
using UsuariosIdentity.Domain.Models;

namespace UsuariosIdentityAPI.Controllers;

[ApiController]
public class UsuariosController : Controller
{
    private readonly IMapper _mapper;
    private readonly UserManager<Usuario> _userManager;
    private readonly UsuarioService _usuarioService;

    public UsuariosController(IMapper mapper, UserManager<Usuario> userManager)
    {
        _mapper = mapper;
        _userManager = userManager;
    }

    //[HttpPost]
    //[Route("api/cadastraUsuario")]
    //public async Task<IActionResult> CadastraUsuario(CreateUsuarioDTO dto)
    //{
    //    _usuarioService.Cadastro(dto);

    //}
}
