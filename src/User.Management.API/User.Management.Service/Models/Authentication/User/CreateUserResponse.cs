using Microsoft.AspNetCore.Identity;

namespace User.Management.Service.Models.Authentication.User
{
    public class CreateUserResponse
    {
        public string Token { get; set; }=null!;
        public IdentityUser User { get; set; } = null!;

    }
   

}
