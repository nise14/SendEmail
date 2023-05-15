using SendEmail.Models;

namespace SendEmail.Services;

public interface IEmailService
{
    void SendEmail(EmailDto request);
}