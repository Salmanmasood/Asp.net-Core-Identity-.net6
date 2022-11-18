

using User.Management.Service.Models;

namespace User.Management.Service.Services
{
    public interface IEmailService
    {
        void SendEmail(Message message);
    }
}
