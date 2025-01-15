using UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Application.Abstraction
{
    public interface IUserService
    {
        IList<User> SelectAll();
        User FindByName(string name);
        User FindById(int id);
        List<User> FindFriends(int id);
        bool Delete(int id);
        bool Update(int id, User user);
    }
}
