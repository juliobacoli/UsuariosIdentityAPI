using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace UsuariosIdentity.Application.Authorization;

public class IdadeAuthorization : AuthorizationHandler<IdadeMinima>
{
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IdadeMinima requirement)
    {
        #region Logica ousada
        ////throw new NotImplementedException();
        //DateTime dataAtual = DateTime.Now;

        //var dataNascimentoClaim = context.User.FindFirst(c => c.Type == ClaimTypes.DateOfBirth);

        //if (dataNascimentoClaim == null)
        //    return Task.CompletedTask;

        ////Converte em DateTime a Claim de data de nascimento pois ela vem como string
        //var dtNascimento = Convert.ToDateTime(dataNascimentoClaim.Value);

        ////var idadeUsuario = DateTime.Today.Year - dtNascimento.Year;

        //int idadeUsuario = dataAtual.Year - dtNascimento.Year - (dtNascimento.Date > dataAtual.AddYears(-1) ? 1 : 0);

        //_ = idadeUsuario >= 18 && (dtNascimento.Month < dataAtual.Month || (dtNascimento.Month == dataAtual.Month && dtNascimento.Day <= dataAtual.Day));

        //return Task.CompletedTask;
        #endregion

        var dataNascimentoClaim = context.User.FindFirst(c => c.Type == ClaimTypes.DateOfBirth);

        if (dataNascimentoClaim == null)
            return Task.CompletedTask;

        var dtNascimento = Convert.ToDateTime(dataNascimentoClaim.Value);

        var idadeUsuario = DateTime.Today.Year - dtNascimento.Year;

        if (dtNascimento > DateTime.Today.AddYears(-idadeUsuario))
            idadeUsuario--;

        if (idadeUsuario >= requirement.Idade)
            context.Succeed(requirement);

        return Task.CompletedTask;
    }
}
