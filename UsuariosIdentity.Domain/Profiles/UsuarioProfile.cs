using AutoMapper;
using UsuariosIdentity.Application.Data.DTOs;
using UsuariosIdentity.Domain.Models;

namespace UsuariosIdentity.Domain.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDTO, Usuario>();
        }
    }
}
