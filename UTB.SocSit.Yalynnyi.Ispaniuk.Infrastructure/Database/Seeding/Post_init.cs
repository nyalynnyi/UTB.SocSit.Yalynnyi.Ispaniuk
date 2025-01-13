using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Database.Seeding
{
    internal class Post_init
    {
        public IList<Post> GetPosts()
        {
            IList<Post> posts = new List<Post>();
            for (int i = 1; i <= 100; i++)
            {
                posts.Add(new Post()
                {
                    ID = i,
                    UserID = (i % 5) + 1,
                    Text = $"This is post number {i} on this network. Enjoy reading!"
                });
            }
            return posts;
        }
    }
}
