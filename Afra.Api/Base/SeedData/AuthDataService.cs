using System.Collections.Generic;


namespace Afra.api.Base.SeedData
{
    public static class AuthDataService
    {
        public static readonly string AdminUserRole = "Admin";
        public static readonly string AdminPassword = "P@ssw0rdadmin";
        public static readonly string CustomerUserRole = "Company";

        public static IEnumerable<string> StaticRoles => new[] { AdminUserRole, "User", CustomerUserRole, "Customer" };


        public static IEnumerable<(string UserName, string Password)> StaticUsers =>
            new[] { ("SAdmin", "P@ssw0rd+-") };

        public static IEnumerable<(string UserName, string Role)> UserRoles => new[] { ("SAdmin", "Admin") };

        public static class JwtClaimIdentifiers
        {
            public const string Rol = "rol", Id = "id";
        }

        public static class JwtClaims
        {
            public const string ApiAccess = "api_access";
        }
    }
}
