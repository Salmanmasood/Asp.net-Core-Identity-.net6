
using Microsoft.AspNetCore.Identity;

namespace User.Management.Service.Models.Authentication.User
{
    public class LoginOtpResponse
    {
        public string Token { get; set; } = null!;
        public bool IsTwoFactorEnable { get; set; } 
        public IdentityUser User { get; set; } = null!;
    }
}
