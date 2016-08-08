using AdminLTE.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;
using AdminLTE.Common;
using AdminLTE.Common.Extensions;

namespace AdminLTE.Data
{
    public class AuditableSignInManager<TUser> : SignInManager<TUser> where TUser : class
    {
        private readonly UserManager<TUser> _userManager;
        private readonly ApplicationDbContext _db;
        private readonly IHttpContextAccessor _contextAccessor;

        public AuditableSignInManager(UserManager<TUser> userManager, IHttpContextAccessor contextAccessor, IUserClaimsPrincipalFactory<TUser> claimsFactory, IOptions<IdentityOptions> optionsAccessor, ILogger<SignInManager<TUser>> logger, ApplicationDbContext dbContext)
            : base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger)
        {
            if (userManager == null)
                throw new ArgumentNullException(nameof(userManager));

            if (dbContext == null)
                throw new ArgumentNullException(nameof(dbContext));

            if (contextAccessor == null)
                throw new ArgumentNullException(nameof(contextAccessor));

            _userManager = userManager;
            _contextAccessor = contextAccessor;
            _db = dbContext;
        }

        public override async Task<SignInResult> PasswordSignInAsync(TUser user, string password, bool isPersistent, bool lockoutOnFailure)
        {
            var result = await base.PasswordSignInAsync(user, password, isPersistent, lockoutOnFailure);

            var appUser = user as IdentityUser;

            if (appUser != null) // We can only log an audit record if we can access the user object and it's ID
            {
                var ip = _contextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();

                UserAudit auditRecord = null;

                switch (result.ToString())
                {
                    case "Succeeded":
                        auditRecord = UserAudit.CreateAuditEvent(appUser.Id, UserAuditEventType.Login, ip);
                        break;

                    case "Failed":
                        auditRecord = UserAudit.CreateAuditEvent(appUser.Id, UserAuditEventType.FailedLogin, ip);
                        break;
                }

                if (auditRecord != null)
                {
                    _db.UserAuditEvents.Add(auditRecord);
                    await _db.SaveChangesAsync();
                }
            }

            return result;
        }

        public override async Task SignOutAsync()
        {
            await base.SignOutAsync();

            var user = await _userManager.FindByIdAsync(_userManager.GetUserId(_contextAccessor.HttpContext.User)) as IdentityUser;

            if (user != null)
            {
                var ip = _contextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();

                var auditRecord = UserAudit.CreateAuditEvent(user.Id, UserAuditEventType.LogOut, ip);
                _db.UserAuditEvents.Add(auditRecord);
                await _db.SaveChangesAsync();
            }
        }
    }
}
