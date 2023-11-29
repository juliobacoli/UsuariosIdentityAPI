using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UsuariosIdentity.Application.Data.DTOs;
using UsuariosIdentity.Domain.Models;


namespace UsuariosIdentity.Application.Services;

public class UsuarioService : IUsuarioService
{
    private readonly IMapper _mapper;
    private readonly UserManager<Usuario> _userManager;

    public UsuarioService(IMapper mapper, UserManager<Usuario> userManager)
    {
        _mapper = mapper;
        _userManager = userManager;
    }

    public async Task CadastraUsuarioAsync(CreateUsuarioDTO dto)
    {
        Usuario usuario = _mapper.Map<Usuario>(dto);

        var result = await _userManager.CreateAsync(usuario, dto.Password);

        if (!result.Succeeded)
            throw new Exception();
        
    }
}
