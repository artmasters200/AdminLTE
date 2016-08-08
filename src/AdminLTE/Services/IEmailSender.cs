using System.Threading.Tasks;

namespace AdminLTE.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
