using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;

namespace AdminLTE.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AvatarURL { get; set; }
        public string DateRegistered { get; set; }
        public string Position { get; set; }
        public string NickName { get; set; }
    }
}
