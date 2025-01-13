using UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Application.Abstraction
{
    public interface IUserService
    {
        IList<User> SelectAll();
        bool Delete(int id);
        bool Update(int id, User user);
    }
}
