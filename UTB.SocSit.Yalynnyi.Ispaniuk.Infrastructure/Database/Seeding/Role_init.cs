using UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Database.Seeding
{
    internal class Role_init
    {
        public IList<Role> GetRoles()
        {
            IList<Role> roles = new List<Role>();
            roles.Add(new Role()
            {
                Id = 1,
                Name = "Admin"
            });
            roles.Add(new Role()
            {
                Id = 2,
                Name = "Moderator"
            });
            roles.Add(new Role()
            {
                Id = 3,
                Name = "User"
            });
            return roles;
        }
    }
}
