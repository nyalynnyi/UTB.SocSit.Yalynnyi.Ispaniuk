using UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Database.Seeding
{
    internal class User_init
    {
        public IList<User> GetUsers()
        {
            IList<User> users = new List<User>();
            users.Add(new User()
            {
                Id = 1,
                Email = "orpha_terry@example.com",
                Nickname = "orpha_terry",
                Photo = "/img/user/default.jpg",
                Name = "Orpha Terry"
            });
            users.Add(new User()
            { 
                Id = 2,
                Email = "marta.berge47@example.com",
                Nickname = "marta_berge",
                Photo = "/img/user/default.jpg",
                Name = "Marta Berge"
            });
            users.Add(new User()
            {
                Id = 3,
                Email = "jamir_kshlerin@example.com",
                Nickname = "j_kshlerin",
                Photo = "/img/user/default.jpg",
                Name = "Jamir Kshlerin"
            });
            users.Add(new User()
            {
                Id = 4,
                Email = "rico_spinka66@example.com",
                Nickname = "rico_spinka",
                Photo = "/img/user/default.jpg",
                Name = "Rico Spinka"
            });
            users.Add(new User()
            {
                Id = 5,
                Email = "ottilie.emmerich43@example.com",
                Nickname = "emmerich43",
                Photo = "/img/user/default.jpg",
                Name = "Ottilie Emmerich"
            });
            return users;
        }
    }
}
