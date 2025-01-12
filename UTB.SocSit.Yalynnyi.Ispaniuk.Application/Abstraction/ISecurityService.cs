using System.Security.Claims;
using UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Application.Abstraction
{
    public interface ISecurityService
    {
        Task<User> FindUserById(string id);
        Task<User> FindUserByUsername(string username);
        Task<User> FindUserByEmail(string email);
        Task<IList<string>> GetUserRoles(User user);
        Task<User> GetCurrentUser(ClaimsPrincipal principal);
    }
}
