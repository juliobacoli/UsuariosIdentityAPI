using System.ComponentModel.DataAnnotations;

namespace UsuariosIdentity.Domain.Models.DTOs;

public class LoginUsuarioDTO 
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}
