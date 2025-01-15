﻿using UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity;

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
                UserName = "orpha_terry",
                Photo = "~/img/photos/default.png",
                Name = "Orpha Terry"
            });
            users.Add(new User()
            { 
                Id = 2,
                Email = "marta.berge47@example.com",
                UserName = "marta_berge",
                Photo = "~/img/photos/default.png",
                Name = "Marta Berge"
            });
            users.Add(new User()
            {
                Id = 3,
                Email = "jamir_kshlerin@example.com",
                UserName = "j_kshlerin",
                Photo = "~/img/photos/default.png",
                Name = "Jamir Kshlerin"
            });
            users.Add(new User()
            {
                Id = 4,
                Email = "rico_spinka66@example.com",
                UserName = "rico_spinka",
                Photo = "~/img/photos/default.png",
                Name = "Rico Spinka"
            });
            users.Add(new User()
            {
                Id = 5,
                Email = "ottilie.emmerich43@example.com",
                UserName = "emmerich43",
                Photo = "~/img/photos/default.png",
                Name = "Ottilie Emmerich"
            });
            return users;
        }
    }
}
