using UTB.SocSit.Yalynnyi.Ispaniuk.Application.ViewModels;
using UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity.Enums;
namespace UTB.SocSit.Yalynnyi.Ispaniuk.Application.Abstraction
{
    public interface IAccountService
    {
        Task<bool> Login(LoginViewModel vm);
        Task Logout();
        Task<string[]> Register(RegisterViewModel vm, params Roles[] roles);
    }
}