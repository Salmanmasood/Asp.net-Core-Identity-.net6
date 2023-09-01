﻿using Microsoft.AspNetCore.Identity;

namespace User.Management.Service.Models.Authentication.User
{
    public class CreateUserResponse
    {
        public string Token { get; set; }
        public IdentityUser User { get; set; }

    }
    public class GetOTPLoginResponse
    {
        public string Token { get; set; }
        public bool IsTwoFactorEnable { get; set; }

    }

}
