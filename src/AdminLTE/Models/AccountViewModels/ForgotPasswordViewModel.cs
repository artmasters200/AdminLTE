using System.ComponentModel.DataAnnotations;

namespace AdminLTE.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
