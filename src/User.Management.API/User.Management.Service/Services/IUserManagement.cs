﻿using Microsoft.AspNetCore.Identity;
using User.Management.Service.Models;
using User.Management.Service.Models.Authentication.Login;
using User.Management.Service.Models.Authentication.SignUp;
using User.Management.Service.Models.Authentication.User;

namespace User.Management.Service.Services
{
    public interface IUserManagement
    { 
        
        /// <summary>
       /// Brief description of what the method does.
       /// </summary>
       /// <param name="registerUser">Description of the parameter.</param>
       /// <returns>Description of the return value.</returns>

        Task<ApiResponse<CreateUserResponse>> CreateUserWithTokenAsync(RegisterUser registerUser);
        Task<ApiResponse<List<string>>> AssignRoleToUserAsync(List<string> roles, IdentityUser user);
        Task<ApiResponse<LoginOtpResponse>> GetOtpByLoginAsync(LoginModel loginModel);


    }
}
