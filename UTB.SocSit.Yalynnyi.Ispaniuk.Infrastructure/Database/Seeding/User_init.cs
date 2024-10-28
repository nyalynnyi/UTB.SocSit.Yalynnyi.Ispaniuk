using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Database.Seeding
{
    internal class User_init
    {
        public IList<User> GetUsers()
        {
            IList<User> users = new List<User>();
            users.Add(new User()
            {
                Email = "orpha_terry@example.com",
                Nickname = "orpha_terry",
                Photo = "/img/user/default.jpg",
                Password = "EXAMPLE_pass_must_be_HASH",
                Name = "Orpha Terry"
            });
            users.Add(new User()
            {
                Email = "marta.berge47@example.com",
                Nickname = "marta_berge",
                Photo = "/img/user/default.jpg",
                Password = "EXAMPLE_pass_must_be_HASH",
                Name = "Marta Berge"
            });
            users.Add(new User()
            {
                Email = "jamir_kshlerin@example.com",
                Nickname = "j_kshlerin",
                Photo = "/img/user/default.jpg",
                Password = "EXAMPLE_pass_must_be_HASH",
                Name = "Jamir Kshlerin"
            });
            users.Add(new User()
            {
                Email = "rico_spinka66@example.com",
                Nickname = "rico_spinka",
                Photo = "/img/user/default.jpg",
                Password = "EXAMPLE_pass_must_be_HASH",
                Name = "Rico Spinka"
            });
            users.Add(new User()
            {
                Email = "ottilie.emmerich43@example.com",
                Nickname = "emmerich43",
                Photo = "/img/user/default.jpg",
                Password = "EXAMPLE_pass_must_be_HASH",
                Name = "Ottilie Emmerich"
            });
            return users;
        }
    }
}
