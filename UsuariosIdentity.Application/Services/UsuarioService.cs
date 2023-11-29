using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UsuariosIdentity.Application.Data.DTOs;
using UsuariosIdentity.Domain.Models;
using UsuariosIdentity.Domain.Models.DTOs;

namespace UsuariosIdentity.Application.Services;

public class UsuarioService : IUsuarioService
{
    private readonly IMapper _mapper;
    private readonly UserManager<Usuario> _userManager;
    private readonly SignInManager<Usuario> _signInManager;

    public UsuarioService(IMapper mapper, UserManager<Usuario> userManager, SignInManager<Usuario> signInManager)
    {
        _mapper = mapper;
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public async Task CadastraUsuarioAsync(CreateUsuarioDTO dto)
    {
        Usuario usuario = _mapper.Map<Usuario>(dto);

        var result = await _userManager.CreateAsync(usuario, dto.Password);

        if (!result.Succeeded)
            throw new Exception();
    }

    public async Task LoginAsync(LoginUsuarioDTO dto)
    {
        #region NOTA
        //NOTA FUTURO: if ternário testando se a chamada do metodo falhou ou fez login corretamente
        //O uso de _ = significa uma variavel descartavel, nesse caso usado para nao declarar outra variável
        #endregion

        _ = (await _signInManager.PasswordSignInAsync(dto.Username, dto.Password, false, false)).Succeeded ? "Login bem-sucedido" : throw new ApplicationException("Usuário não autenticado!");
    }
}
