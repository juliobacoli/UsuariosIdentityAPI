using Microsoft.AspNetCore.Mvc;
using UsuariosIdentity.Application.Data.DTOs;

namespace UsuariosIdentityAPI.Controllers
{
    public class UsuariosController : Controller
    {
        [HttpPost]
        public IActionResult CadastraUsuario(CreateUsuarioDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
