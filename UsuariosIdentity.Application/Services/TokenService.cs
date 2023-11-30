using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UsuariosIdentity.Domain.Models;

namespace UsuariosIdentity.Application.Services;

public class TokenService : ITokenService
{
    public TokenService()
    {
    }

    public async Task<string> GerarToken(Usuario user)
    {
        Claim[] claims = new Claim[]
        {
            new Claim("username", user.UserName),
            new Claim("id", user.Id),
            new Claim(ClaimTypes.DateOfBirth, user.DataNascimento.ToString())
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("aBcDeFgH1234567890IjKlMnOpQrStUvWxYz"));
        var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken
            (expires: DateTime.Now.AddHours(8),
            claims: claims,
            signingCredentials: signingCredentials);

        await Task.CompletedTask;

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
