using System.Linq;
using System.Security.Claims;

namespace AdminLTE.Common.Extensions
{
    public static class IdentityExtension
    {
        /// <summary>
        /// //Use CustomClaimTypes when using this method
        /// </summary>
        /// <param name="user"></param>
        /// <param name="claimType">Use [CustomClaimTypes] when using this method</param>
        /// <returns></returns>
        public static string GetUserProperty(this ClaimsPrincipal user, string claimType)
        {
            if (user.Identity.IsAuthenticated)
            {
                return user.Claims.FirstOrDefault(v => v.Type == claimType)?.Value ?? string.Empty;
            }

            return string.Empty;
        }
    }
}
