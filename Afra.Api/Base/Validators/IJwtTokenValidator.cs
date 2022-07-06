using System.Security.Claims;

namespace Afra.api.Base.Validators
{
    public interface IJwtTokenValidator
    {
        ClaimsPrincipal GetPrincipalFromToken(string token, string signingKey);
    }
}
