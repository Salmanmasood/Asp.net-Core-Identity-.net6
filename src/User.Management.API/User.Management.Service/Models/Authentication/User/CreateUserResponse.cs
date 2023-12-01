using Microsoft.AspNetCore.Identity;
using User.Management.Data.Models;

namespace User.Management.Service.Models.Authentication.User
{
    public class CreateUserResponse
    {
        public string Token { get; set; }=null!;
        public ApplicationUser User { get; set; } = null!;

    }
   

}
