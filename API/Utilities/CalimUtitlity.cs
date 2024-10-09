using System.Security.Claims;

namespace API.Utilities
{
    public static class CalimUtitlity
    {
        public static string GetUserId(ClaimsPrincipal user)
        {
            var cliamsIdentity = user.Identity as ClaimsIdentity;
            string userId = cliamsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
            return userId;
        }
    }
}
