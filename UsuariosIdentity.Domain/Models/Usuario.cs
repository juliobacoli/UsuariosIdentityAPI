using Microsoft.AspNetCore.Identity;

namespace UsuariosIdentity.Domain.Models
{
    public class Usuario : IdentityUser
    {
        public Usuario() : base() { }

        public DateTime DataNascimento { get; set; }
    }
}
