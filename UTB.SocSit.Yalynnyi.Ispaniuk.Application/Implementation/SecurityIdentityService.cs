using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity;
using UTB.SocSit.Yalynnyi.Ispaniuk.Application.Abstraction;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Application.Implementation
{
    public class SecurityIdentityService : ISecurityService
    {
        UserManager<User> userManager;
        public SecurityIdentityService(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }
        public Task<User> FindUserById(string id)
        {
            return userManager.FindByIdAsync(id);
        }
        public Task<User> FindUserByEmail(string email)
        {
            return userManager.FindByEmailAsync(email);
        }
        public Task<User> FindUserByUsername(string username)
        {
            return userManager.FindByNameAsync(username);
        }
        public Task<IList<string>> GetUserRoles(User user)
        {
            return userManager.GetRolesAsync(user);
        }
        public Task<User> GetCurrentUser(ClaimsPrincipal principal)
        {
            return userManager.GetUserAsync(principal);
        }
    }
}
