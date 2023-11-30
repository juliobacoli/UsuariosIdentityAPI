using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UsuariosIdentity.API.Controllers;

[ApiController]
public class AcessoController : Controller
{
    [HttpGet]
    [Authorize(Policy = "IdadeMinima")]
    [Route("api/Acesso")]
    public async Task<IActionResult> ValidarAcresso()
    {
        return Ok("Acesso permitido!");
    }
}
