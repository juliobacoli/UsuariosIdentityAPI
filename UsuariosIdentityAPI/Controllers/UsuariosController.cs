using Microsoft.AspNetCore.Mvc;

namespace UsuariosIdentityAPI.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
