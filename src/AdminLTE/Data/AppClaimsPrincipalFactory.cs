using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using AdminLTE.Common;
using AdminLTE.Models;

namespace AdminLTE.Data
{
    public class AppClaimsPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUser, IdentityRole>
    {
        public AppClaimsPrincipalFactory(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IOptions<IdentityOptions> optionsAccessor) : base(userManager, roleManager, optionsAccessor)
        {
        }

        public override async Task<ClaimsPrincipal> CreateAsync(ApplicationUser user)
        {
            var principal = await base.CreateAsync(user);

            ((ClaimsIdentity)principal.Identity).AddClaims(new[] {
                new Claim(CustomClaimTypes.GivenName, user.FirstName),
                new Claim(CustomClaimTypes.Surname, user.LastName),
                new Claim(CustomClaimTypes.AvatarURL, user.AvatarURL),
                new Claim(CustomClaimTypes.Position, user.Position),
                new Claim(CustomClaimTypes.NickName, user.NickName),
                new Claim(CustomClaimTypes.DateRegistered, user.DateRegistered),
            });

            return principal;
        }
    }
}