using System.Security.Claims;

namespace Project.EndPoint.Utilities
{
    public static class ClaimUtility
    {
        public static string GetUserId(ClaimsPrincipal user)
        {
            var cliamsIdentity = user.Identity as ClaimsIdentity;
            string userId = cliamsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
            return userId;
        }

        public static string GetUserName(ClaimsPrincipal user)
        {
            var cliamsIdentity = user.Identity as ClaimsIdentity;
            string userId = cliamsIdentity.FindFirst(ClaimTypes.Name).Value;
            return userId;
        }
    }

}
